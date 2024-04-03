# Projeto de Demostração de uso do C# e como backend e Next como Frontend

O Objetivo desse projeto é demostrar como podemos usar o C# como backend e o Next como frontend.

## 1. Banco de Dados

### 1.1 Instalar pelas Migrations

Banco de dados escolido foi o SQL Server.

o nome do banco é: `AlocarDB`, ele já deve estar criado no servidor 

Usei a seguinte string de conexão: `Server=localhost;Database=AlocarDB;Trusted_Connection=True;`

Para rodar as migrations, vá no menu Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes e execute no terminal:

Basta rodar o comando: `update-database` no projeto padrão: Infraestructure.Data

### 1.2 Instalar pelo Dump

O nome do banco é: `AlocarDB`, ele já deve estar criado no servidor 

Pode rodar o arquivo `AlocarDB.sql` que está na raiz do projeto e criar manualmente o banco de dados.

## 2. Backend

### 2.1 Rodar o projeto