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

Para instalar as dependências necessárias para execução do projeto, execute os comandos a seguir na pasta raiz do projeto:

<span id="execucao">

## 🚀 Execução

Antes de executar o projeto, é necessário duplicar o arquivo ```example-appsettings.json``` e renomear a cópia para ```appsettings.json```. Este arquivo contém um JSON com configurações utilizadas na aplicação. No campo ConnectionStrings, edite a string de conexão DefaultConnection e modifique os valores < xxxx > de acordo com o que é solicitado para realizar a conexão com o banco de dados PostgreSQL.  

Após isso, é necessário realizar a migração do banco de dados através dos seguintes comandos:
