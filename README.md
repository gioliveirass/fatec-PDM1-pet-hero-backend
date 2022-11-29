<h1 align="center"> 🐱 Pet Hero - Backend 🐶 </h1>

<span id="topo">
<p align="center">
    <a href="#introducao">Introdução</a>  |  
    <a href="#tecnologias">Tecnologias</a>  |  
    <a href="#dependencias">Dependências</a>  |  
    <a href="#execucao">Execução</a>
</p>

<span id="introducao">

## :bookmark_tabs: Introdução

Pet Hero é um projeto desenvolvido com o objetivo de compor nota na disciplina de Programação para Dispositivos Móveis I, na [Faculdade de Tecnologia de São José dos Campos](http://fatecsjc-prd.azurewebsites.net/index.php).
O projeto conta com o desenvolvimento de uma aplicação capaz de auxiliar seus usuários nas tarefas de cuidado com seus respectivos pets. 
Em outras palavras, o tutor será capaz de acompanhar as necessidades de seus companheiros fofos de forma simples e eficiênte, podendo planejar melhor sua rotina com base nas informações disponibilizadas na aplicação.

O presente repositório contém o código desenvolvido no backend da aplicação Pet Hero. Ao longo deste README.md, diversas informações sobre tecnologias e formas de execução relacionadas exclusivamente ao backend serão apresentadas.

> ℹ️ Para vizualisar o repositório Frontend, [clique aqui](https://github.com/gioliveirass/fatec-PDM1-pet-hero-frontend).

<span id="tecnologias">

## 🛠️ Tecnologias

As seguintes tecnologias foram utilizadas para o desenvolvimento backend do projeto Pet Hero:

<img src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white" alt="PostgreSQL" />
<img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
<img src="https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&logo=docker&logoColor=white" alt="Docker" />
<img src="https://img.shields.io/badge/Insomnia-5849be?style=for-the-badge&logo=Insomnia&logoColor=white" alt="Insomnia" />
<img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white" alt="Visual Studio" />
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
<img src="https://img.shields.io/badge/Entity_Framework-1381C1?style=for-the-badge" alt="Entity Framework" />

<span id="dependencias">

## ⚡ Dependências

Para instalar as dependências necessárias para execução do projeto, execute os comandos a seguir na pasta raiz (```/PetHero```):

```
# dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
# dotnet add package Microsoft.AspNetCore.OpenApi
# dotnet add package Microsoft.EntityFrameworkCore
# dotnet add package Microsoft.EntityFrameworkCore.Relational.Design
# dotnet add package Microsoft.EntityFrameworkCore.Tools
# dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
# dotnet add package Npgsql.Json.NET
```

<span id="execucao">

## 🚀 Execução

Antes de executar o projeto, é necessário duplicar o arquivo ```example-appsettings.json``` e renomear a cópia para ```appsettings.json```. Nesse arquivo, há um JSON com algumas configurações utilizadas na aplicação.

No campo ConnectionStrings presente no arquivo ```appsettings.json``` se encontra a string de conexão com o banco de dados PostgreSQL. Por padrão, existe uma string de conexão nomeada DefaultConnection, e será necessário editar a mesma para substituir os valores < xxxx > pelos dados necessários apresentados na tabela a seguir:

| Label | Descrição |
| ----- | --------- |
| Database | Nome do database |
| User Id | Usuário para acessar o database |
| Password | Senha para acessar o database |

Após atualizar a string de conexão, é necessário criar uma migração para modelar o banco de dados de acordo com as necessidades do projeto e, em seguida, atualizar o banco de dados. Isso pode ser feito através dos seguintes comandos (que devem ser executados na pasta raiz ```/PetHero```):

```
# dotnet ef migrations add InitialCreate
# dotnet ef database update
```

Uma vez que as configurações iniciais descritas anteriormente tenham sido realizadas, basta executar o comando a seguir na pasta raiz (```/PetHero```) para iniciar o projeto:

```
# dotnet run
```

<hr>
<p align="center">
  ✨ Projeto desenvolvido por <a href="https://github.com/gioliveirass">@gioliveirass</a> ✨
  <br><br>
  <img src="https://img.shields.io/badge/Made%20with-Magic-orange?style=for-the-badge&logo=data:image/svg%2bxml;base64,PHN2ZyBpZD0iQ2FwYV8xIiBlbmFibGUtYmFja2dyb3VuZD0ibmV3IDAgMCA1MTIgNTEyIiBoZWlnaHQ9IjUxMiIgdmlld0JveD0iMCAwIDUxMiA1MTIiIHdpZHRoPSI1MTIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PGc+PHBhdGggZD0ibTM5NS44MiAxODIuNjE2LTE4OC43MiAxODguNzItMTIuOTEgMS43Mi05LjM1IDIwLjU0LTM0LjMxIDM0LjMxLTExLjAxLS43My0xMS4yNSAyMi45OS01Ni40OCA1Ni40OGMtMi45MyAyLjkzLTYuNzcgNC4zOS0xMC42MSA0LjM5cy03LjY4LTEuNDYtMTAuNjEtNC4zOWwtMjIuNjItMjIuNjJoLS4wMWwtMjIuNjItMjIuNjNjLTUuODYtNS44Ni01Ljg2LTE1LjM2IDAtMjEuMjJsNzcuNjMtNzcuNjMgMTYuNi03LjAzIDUuNjYtMTUuMjMgMzQuMzEtMzQuMzEgMTQuODQtNC45MiA3LjQyLTE3LjM0IDE2Ny41Ny0xNjcuNTcgMzMuMjQgMzMuMjR6IiBmaWxsPSIjZjY2Ii8+PHBhdGggZD0ibTM5NS44MiAxMTYuMTQ2djY2LjQ3bC0xODguNzIgMTg4LjcyLTEyLjkxIDEuNzItOS4zNSAyMC41NC0zNC4zMSAzNC4zMS0xMS4wMS0uNzMtMTEuMjUgMjIuOTktNTYuNDggNTYuNDhjLTIuOTMgMi45My02Ljc3IDQuMzktMTAuNjEgNC4zOXMtNy42OC0xLjQ2LTEwLjYxLTQuMzlsLTIyLjYyLTIyLjYyIDMzNC42NC0zMzQuNjR6IiBmaWxsPSIjZTYyZTZiIi8+PHBhdGggZD0ibTUwNi42MSAyMDkuMDA2LTY5LjE0LTY5LjEzIDQzLjA1LTg4LjM4YzIuOC01Ljc1IDEuNjUtMTIuNjUtMi44OC0xNy4xNy00LjUyLTQuNTMtMTEuNDItNS42OC0xNy4xNy0yLjg4bC04OC4zOCA0My4wNS02OS4xMy02OS4xNGMtNC4zNS00LjM1LTEwLjkyLTUuNi0xNi41Ni0zLjE2LTUuNjUgMi40NS05LjIzIDguMDktOS4wNCAxNC4yNGwyLjg2IDkwLjQ1LTg1LjM3IDU3LjgzYy00LjkxIDMuMzItNy40IDkuMjItNi4zNiAxNS4wNCAxLjA0IDUuODMgNS40IDEwLjUxIDExLjE1IDExLjk0bDk2LjYyIDI0LjAxIDI0LjAxIDk2LjYyYzEuNDMgNS43NSA2LjExIDEwLjExIDExLjk0IDExLjE1Ljg3LjE2IDEuNzUuMjMgMi42Mi4yMyA0LjkyIDAgOS42LTIuNDIgMTIuNDItNi41OWw1Ny44My04NS4zNyA5MC40NSAyLjg2YzYuMTQuMTkgMTEuNzktMy4zOSAxNC4yNC05LjA0IDIuNDQtNS42NCAxLjE5LTEyLjIxLTMuMTYtMTYuNTZ6IiBmaWxsPSIjZmFiZTJjIi8+PHBhdGggZD0ibTI5Ni4yNiAyMTUuNzA2IDI0LjAxIDk2LjYyYzEuNDMgNS43NSA2LjExIDEwLjExIDExLjk0IDExLjE1Ljg3LjE2IDEuNzUuMjMgMi42Mi4yMyA0LjkyIDAgOS42LTIuNDIgMTIuNDItNi41OWw1Ny44My04NS4zNyA5MC40NSAyLjg2YzYuMTQuMTkgMTEuNzktMy4zOSAxNC4yNC05LjA0IDIuNDQtNS42NCAxLjE5LTEyLjIxLTMuMTYtMTYuNTZsLTY5LjE0LTY5LjEzIDQzLjA1LTg4LjM4YzIuOC01Ljc1IDEuNjUtMTIuNjUtMi44OC0xNy4xN3oiIGZpbGw9IiNmZDkwMjUiLz48cGF0aCBkPSJtNDY1IDQxNi45NjZjLTI1LjkyIDAtNDcgMjEuMDgtNDcgNDdzMjEuMDggNDcgNDcgNDcgNDctMjEuMDggNDctNDctMjEuMDgtNDctNDctNDd6IiBmaWxsPSIjZmFiZTJjIi8+PHBhdGggZD0ibTEwNCAyOC45NjZoLTEzdi0xM2MwLTguMjg0LTYuNzE2LTE1LTE1LTE1cy0xNSA2LjcxNi0xNSAxNXYxM2gtMTNjLTguMjg0IDAtMTUgNi43MTYtMTUgMTVzNi43MTYgMTUgMTUgMTVoMTN2MTNjMCA4LjI4NCA2LjcxNiAxNSAxNSAxNXMxNS02LjcxNiAxNS0xNXYtMTNoMTNjOC4yODQgMCAxNS02LjcxNiAxNS0xNXMtNi43MTYtMTUtMTUtMTV6IiBmaWxsPSIjZmVkODQzIi8+PHBhdGggZD0ibTIwNy4xIDM3MS4zMzYtMjIuMjYgMjIuMjYtNDUuMzItODcuNjIgMjIuMjYtMjIuMjZ6IiBmaWxsPSIjZmVkODQzIi8+PHBhdGggZD0ibTE4NC44NCAzOTMuNTk2IDIyLjI2LTIyLjI2LTIyLjY2LTQzLjgxLTIyLjI2NSAyMi4yNjV6IiBmaWxsPSIjZmFiZTJjIi8+PHBhdGggZD0ibTE1MC41MyA0MjcuOTA2LTIyLjI2IDIyLjI2LTQ1LjMyLTg3LjYyIDIyLjI2LTIyLjI2eiIgZmlsbD0iI2ZlZDg0MyIvPjxwYXRoIGQ9Im0xMjguMjcgNDUwLjE2NiAyMi4yNi0yMi4yNi0yMi42NTUtNDMuODE1LTIyLjI2IDIyLjI2eiIgZmlsbD0iI2ZhYmUyYyIvPjxjaXJjbGUgY3g9IjE1IiBjeT0iMTE5Ljk2OSIgZmlsbD0iIzVlZDhkMyIgcj0iMTUiLz48Y2lyY2xlIGN4PSIxMjgiIGN5PSIxOTkuOTY5IiBmaWxsPSIjZDU5OWVkIiByPSIxNSIvPjxjaXJjbGUgY3g9IjE5MiIgY3k9IjYzLjk2NCIgZmlsbD0iI2Y2NiIgcj0iMTUiLz48Y2lyY2xlIGN4PSIzMjgiIGN5PSI0MTUuOTY3IiBmaWxsPSIjMzFiZWJlIiByPSIxNSIvPjxjaXJjbGUgY3g9IjQ0MCIgY3k9IjMyNy45NjciIGZpbGw9IiNhZDc3ZTMiIHI9IjE0Ljk5OSIvPjwvZz48L3N2Zz4=">
</p>
