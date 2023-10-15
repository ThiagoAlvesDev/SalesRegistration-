## Sistema de Registro de Vendas

* Este é um sistema web para o registro de vendas, onde é possível criar, editar e excluir vendedores, departamentos e registros de vendas. O projeto foi desenvolvido com base na arquitetura MVC (Model-View-Controller) e utiliza o Entity Framework para interagir com o banco de dados. A aplicação foi construída na plataforma .NET e utiliza a linguagem de programação C#.

## Arquitetura
* O sistema de Registro de Vendas segue a arquitetura Model-View-Controller (MVC). Esta arquitetura divide a aplicação em três componentes principais:

* Model (Modelo): O Modelo é responsável por representar os dados da aplicação e as regras de negócios. No caso deste sistema, o modelo inclui representações de vendedores, departamentos e registros de vendas. O Entity Framework é usado para mapear esses modelos para o banco de dados.

* View (Visão): A Visão é a camada de apresentação da aplicação, onde os usuários interagem com o sistema. Neste projeto, as views são responsáveis por exibir os dados e coletar informações dos usuários.

* Controller (Controlador): O Controlador atua como intermediário entre o Modelo e a Visão. Ele processa as solicitações dos usuários, interage com o Modelo e atualiza a Visão de acordo. Os controladores neste sistema respondem às ações do usuário, como criar, editar e excluir registros.

* As bibliotecas utilizadas no projeto podem ser  visualizadas em [PackageReference.txt](/SalesWebMVC/PackageReference.txt)

## Frameworks e Tecnologias Utilizados
* .NET Platform: O sistema é construído na plataforma .NET, que é um ambiente de desenvolvimento robusto da Microsoft. A plataforma .NET oferece uma ampla variedade de ferramentas e recursos para o desenvolvimento de aplicativos.

* C# Programming Language: A linguagem de programação C# é utilizada para desenvolver a lógica de negócios do sistema. É uma linguagem de programação orientada a objetos amplamente utilizada no ecossistema .NET.

* Entity Framework: O Entity Framework é um framework ORM (Object-Relational Mapping) que permite a interação com o banco de dados de forma orientada a objetos. Ele simplifica o acesso aos dados do banco de dados e é usado neste projeto para mapear os modelos de dados para o banco de dados. Neste sistema foi utilizado o banco de dados MySql junto com a ferrementa MySQL Workbench.

