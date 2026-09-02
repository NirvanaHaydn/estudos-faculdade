# Modelagem de Dados - Anotações

* Um Banco de Dados (BD)/base de dados é uma coleção de dados relacionados.
* É uma coleção de dados persistentes, usados pelos sistemas de aplicação de uma determinada empresa. Ele pode ser entendido também como um conjunto de dados integrados que têm por objetivo atender a uma comunidade de usuários.
* Ao modelarmos um banco de dados, precisamos ter em mente primeiro quem vai usar esse BD e por que precisa usá-lo.
* Funções: armazenar, buscar e tratar dados.
* Bancos de dados podem ter vários tamanhos e diferentes níveis de complexidade.
* Representam algum aspecto do mundo real.
* Foco no conteúdo e nos tipos de dados que serão armazenados (dados de clientes, dados de pacientes, dados de materiais em estoque).

**SGBDs (Sistema Gerenciador de BD)** são softwares que incorporam as funções de definição, recuperação e alteração de dados em um banco de dados.

* Foco nas tecnologias em si (Oracle, MySQL, Microsoft SQL Server...).
* Antes do aparecimento dos primeiros SGBDs, a única opção para manipular dados era o enfoque de arquivos. Nesta abordagem, os arquivos eram projetados tendo em mente apenas sua aplicação específica (arquivos de clientes do sistema de contas-correntes do banco, arquivos de alunos do sistema da biblioteca). Isso gerava uma série de problemas.
* Falta da visão de Administração de Dados.

**Abordagem Isolada de Armazenamento de Dados: Sistema de Arquivos (anos 60/70)**

* Cada aplicação era proprietária da sua base de dados particular, dando muita liberdade para o desenvolvedor modelar os seus arquivos.
* Registros eram armazenados em vários arquivos (tabelas) e diferentes arquivos eram escritos para extrair ou adicionar dados.
* Isso criava sistemas isolados.

### Problemas gerados

* **Redundância de dados:** arquivos e programas são criados por diferentes programadores, fazendo com que a mesma informação seja duplicada em diversos lugares.
* **Custo maior de armazenamento.**
* **Inconsistência de dados:** várias cópias do mesmo dado não são coerentes.
* **Dificuldade de aproveitamento de dados em novas aplicações:** os dados estão espalhados em vários arquivos que podem estar em diferentes formatos.
* **Dificuldade no acesso a dados:** a principal maneira de obter os dados é por meio de programas, havendo poucas ferramentas amigáveis para a elaboração de consultas pelos usuários.
* **Inexistência de controle centralizado dos dados (Administração de Dados):** os dados podem ser acessados por muitos programas diferentes que não foram previamente coordenados, ocasionando problemas de segurança e supervisão.

### Vantagens da Abordagem Integrada de BD

* Controle de redundância e inconsistência de dados.
* Restrição de acesso não autorizado.
* Armazenamento persistente.
* Existência de recursos para backup e recuperação.
* Imposição de restrições de integridade e regras de negócio.
* Processamento eficiente de consulta
* Múltiplas interfaces: dados vistos de forma mais adequada por aplicação do usuário
* Favorece controle mais centralizado de dados

# Tipos de Linguagens (DDL e DML) e Tipos de Profissionais de BD

## DML e DDL

* **DML (Data Manipulation Language):** de uso mais frequente pelos desenvolvedores de BD para consultar, incluir, alterar e excluir dados. A DML pode ser procedural ou não procedural.
* **DDL (Data Definition Language):** de uso mais restrito pelos DBAs para criar, alterar e excluir estruturas (tabelas, índices, visões) do BD.

Um esquema de banco de dados precisa de uma linguagem para ser especificado e construído (**DDL** — ligada aos ADs, restrita aos DBAs) e de uma linguagem para a manipulação dos dados (**DML** — ligada aos desenvolvedores).

### DDL

**DDL > Linguagem de Definição de Dados.**

Permite a especificação da base de dados, definindo os arquivos, as ligações entre arquivos, os registros e as variáveis dos registros.

### DML

**DML > Linguagem de Manipulação de Dados.**

Permite a consulta e a atualização (inclusão, alteração e exclusão) da base de dados definida pela DDL.

A DML pode ser:

* **Procedural:** o usuário tem que especificar qual dado é necessário e como obtê-lo. É uma abordagem inicial do ponto de vista dos bancos de dados hierárquicos e dos bancos de dados em redes. É como um motorista de táxi para quem temos que indicar exatamente qual caminho queremos seguir.
* A DML dos bancos de dados relacionais (padrão SQL) é **não procedural**.
* **Não procedural:** possui uma camada maior de abstração; o usuário não define como os dados serão acessados. É como simplesmente dizer ao motorista de táxi onde queremos ir.
* Cabe ao **Otimizador do SGBD** definir o melhor caminho de acesso aos dados no momento do processo da consulta.

---

# Tipos de Profissionais de Banco de Dados

Os principais participantes de um projeto de BD são:

## Administrador de Dados (AD)

* Visão mais lógica e de modelagem: **"Arquiteto"**.
* Define a estrutura de informação da empresa (base de dados).
* Administra a descrição da base de dados (dicionário de dados).
* Define padrões para codificação de objetos da base de dados (tabelas, nomes de campos).
* Zela pelo modelo corporativo de dados.
* Conhece profundamente as regras de negócio da empresa: visão mais específica.

## Administrador de Banco de Dados (DBA — Database Administrator)

* Visão mais física de implementação: **"Engenheiro"**.
* Perfil de Analista de Suporte: performance, otimização, armazenamento.
* Gerencia a base de dados instalada.
* Modifica a estrutura de armazenamento e a organização física: migrações, carga de dados, atualização de versões.
* Fornece e controla as autorizações de acesso ao SGBD.
* Administra o SGBD.
* Deve ser o especialista no SGBD.

## Analista de Sistemas / Engenheiro de Software / Desenvolvedor

* Coleta os requisitos e as necessidades de informações dos usuários finais.
* Desenvolve os sistemas que acessam bancos de dados.
* Trabalha juntamente com o AD na modelagem do BD.
* Trabalha juntamente com o DBA na implementação do BD.

## Usuário Final

* Acessa o banco de dados para consultas, atualizações e geração de relatórios.
* Diferenças entre usuário de nível operacional e de nível gerencial.
# Níveis do SGBD e Etapas do Projeto de BD

## Níveis do SGBD

* O SGBD deve prover aos usuários uma visão abstrata dos dados.
* Os níveis de abstração simplificam a interação do usuário com o sistema.

O SGBD pode ser dividido em 3 níveis:

### Nível Interno ou Físico

* Nível mais baixo, pois descreve como os dados estão realmente armazenados.
* Trata da alocação de espaço em disco e do uso de índices para melhorar a performance.
* Principal nível de atuação do DBA.

### Nível Conceitual ou Lógico

* Este nível descreve quais dados são armazenados no BD e quais os relacionamentos entre eles.
* Baseado na modelagem de dados.
* Principal nível de atuação do AD.

### Nível Externo ou de Visão

* Visão de cada usuário, sejam estes desenvolvedores ou usuários finais.
* Os usuários necessitam de apenas uma parte do BD.
* Podem haver diferentes visões providas pelo sistema para um mesmo BD.

### Independência Física

A **independência física** ocorre quando alterações no nível físico não provocam modificações no nível conceitual (ex.: criação de índices).

Alterações no nível físico são necessárias ocasionalmente para melhorar a performance.

### Independência Lógica

Já a **independência lógica** ocorre quando alterações no nível conceitual não provocam modificações no nível de visão.

A independência lógica é mais difícil de ser atingida do que a independência física, uma vez que os programas são muito dependentes da estrutura lógica dos dados que manipulam.

**Ex.:** adição de campos em tabelas.

---

# Etapas do Projeto de BD

**Levantamento dos Requisitos (requisitos da aplicação) → Projeto Conceitual (MER) → Projeto Lógico (modelo relacional, orientado a objetos, etc.) → Projeto Físico (implementação do BD)**

## Projeto Conceitual

O **Projeto Conceitual do BD** descreve a estrutura de informação sem se preocupar em qual SGBD a base de dados vai residir.

Nesta fase, é feita a definição dos tipos de dados que o sistema manipula e como esses dados se relacionam.

* **Entrada:** enunciado informal e incompleto de requisitos do usuário.
* **Produto Final:** visão macro do BD, esquema conceitual.
* Esta fase deve contar com a participação do Administrador de Dados, do usuário final e do analista de sistemas.

## Projeto Lógico

O **Projeto Lógico do BD** detalha e descreve um modelo de dados gerado na fase anterior para uma determinada classe de SGBD (relacional, OO, hierárquico, rede).

* **Entrada:** esquema conceitual.
* **Resultado:** esquema lógico descrevendo as estruturas de representação.
* Essa fase conta com a participação do AD, do DBA e do analista.

## Projeto Físico

Por fim, o **Projeto Físico do BD** define de que maneira o projeto lógico será fisicamente armazenado, implicando na definição do espaço necessário em disco, da periodicidade dos backups, do volume de alteração dos dados e do número e perfil dos usuários que terão acesso aos dados.

* **Entrada:** esquema lógico.
* **Resultado:** script DDL para o SGBD específico.
* Melhoria da performance por meio da identificação de processos mais críticos.
* Essa fase deve contar com a participação do DBA e do engenheiro de software.
