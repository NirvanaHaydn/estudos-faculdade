import os
import re
import sys
from collections import defaultdict

import requests

PROJECT_NUMBER = 2
OWNER = "NirvanaHaydn"

GRAPHQL_URL = "https://api.github.com/graphql"
PROJECT_TOKEN = os.environ["PROJECT_TOKEN"]

README_PATH = "README.md"
START_MARKER = "<!-- DASHBOARD:START -->"
END_MARKER = "<!-- DASHBOARD:END -->"

QUERY = """
query($login: String!, $number: Int!) {
  user(login: $login) {
    projectV2(number: $number) {
      title
      url
      items(first: 100) {
        nodes {
          id
          content {
            __typename
            ... on Issue {
              number
              title
              url
              state
            }
          }
          fieldValues(first: 20) {
            nodes {
              ... on ProjectV2ItemFieldSingleSelectValue {
                name
                field {
                  ... on ProjectV2SingleSelectField {
                    name
                  }
                }
              }
              ... on ProjectV2ItemFieldIterationValue {
                title
                startDate
                duration
                field {
                  ... on ProjectV2IterationField {
                    name
                  }
                }
              }
              ... on ProjectV2ItemFieldDateValue {
                date
                field {
                  ... on ProjectV2Field {
                    name
                  }
                }
              }
            }
          }
        }
      }
    }
  }
}
"""


def get_project():
    response = requests.post(
        GRAPHQL_URL,
        headers={
            "Authorization": f"Bearer {PROJECT_TOKEN}",
            "Content-Type": "application/json",
        },
        json={
            "query": QUERY,
            "variables": {
                "login": OWNER,
                "number": PROJECT_NUMBER,
            },
        },
    )

    response.raise_for_status()

    data = response.json()

    if "errors" in data:
        raise RuntimeError(data["errors"])

    return data["data"]["user"]["projectV2"]


def extract_issue_row(item):
    """Transforma um item bruto do Project em um dicionário simples
    com status e sprint já resolvidos, ou None se não for uma Issue."""

    content = item.get("content")

    if not content or content.get("__typename") != "Issue":
        return None

    status = "Sem status"
    sprint = "-"

    for field_value in item["fieldValues"]["nodes"]:
        field = field_value.get("field", {})
        field_name = (field.get("name") or "").strip().lower()

        
        if "name" in field_value and "duration" not in field_value:
            if field_name == "status":
                status = field_value["name"]

        
        if "title" in field_value and "duration" in field_value:
            sprint = field_value["title"]

    return {
        "number": content["number"],
        "title": content["title"],
        "url": content["url"],
        "state": content["state"],
        "status": status,
        "sprint": sprint,
    }



STATUS_ORDER = ["Todo", "To Do", "In Progress", "In Review", "Done"]


def sort_key(status):
    if status in STATUS_ORDER:
        return (0, STATUS_ORDER.index(status))
    return (1, status)


def build_dashboard_markdown(project):
    issues = []

    for item in project["items"]["nodes"]:
        row = extract_issue_row(item)
        if row:
            issues.append(row)

    groups = defaultdict(list)
    for issue in issues:
        groups[issue["status"]].append(issue)

    lines = []
    lines.append(f"### 📋 [{project['title']}]({project['url']})")
    lines.append("")

    if not issues:
        lines.append("_Nenhuma issue encontrada no momento._")
    else:
        for status in sorted(groups.keys(), key=sort_key):
            group_issues = groups[status]
            lines.append(f"**{status}** ({len(group_issues)})")
            lines.append("")
            lines.append("| Issue | Sprint | Estado |")
            lines.append("|---|---|---|")

            for issue in group_issues:
                title = issue["title"].replace("|", "\\|")
                lines.append(
                    f"| [#{issue['number']} {title}]({issue['url']}) "
                    f"| {issue['sprint']} | {issue['state']} |"
                )

            lines.append("")

    return "\n".join(lines).rstrip()


def update_readme(dashboard_md):
    with open(README_PATH, "r", encoding="utf-8") as f:
        content = f.read()

    if START_MARKER not in content or END_MARKER not in content:
        print(
            f"Marcadores {START_MARKER} / {END_MARKER} não encontrados em "
            f"{README_PATH}. Adicione-os manualmente uma vez antes de rodar "
            f"a automação."
        )
        sys.exit(1)

    pattern = re.compile(
        re.escape(START_MARKER) + r".*?" + re.escape(END_MARKER), re.DOTALL
    )
    new_block = f"{START_MARKER}\n{dashboard_md}\n{END_MARKER}"
    new_content = pattern.sub(new_block, content)

    if new_content == content:
        print("README já está atualizado, nada para mudar.")
        return False

    with open(README_PATH, "w", encoding="utf-8") as f:
        f.write(new_content)

    print("README atualizado com sucesso.")
    return True


def main():
    project = get_project()
    print(f"Project encontrado: {project['title']}")

    dashboard_md = build_dashboard_markdown(project)
    update_readme(dashboard_md)


if __name__ == "__main__":
    main()