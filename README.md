![Logo do Projeto](img/logo.png)

<hr>

<p align="center">
   <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge" #vitrinedev/>
</p>

### Tópicos

- [Descrição do projeto](#descrição-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Tecnologias utilizadas](#tecnologias-utilizadas)
- [Acesso ao projeto](#acesso-ao-projeto)
- [Abrir e rodar o projeto](#abrir-e-rodar-o-projeto)
- [Desenvolvedor](#desenvolvedor)

## Descrição do projeto

<p align="justify">
 Este projeto é um estudo prático para aprender a criar APIs com .NET 8. O objetivo é desenvolver uma API que gerencia o estoque de produtos, permitindo operações como cadastro, atualização, exclusão e listagem de produtos, além de organizá-los por categorias e prateleiras. O projeto faz parte de um curso da Udemy e utiliza tecnologias modernas como Entity Framework Core, MySQL e Swagger para documentação da API.
</p>

## Funcionalidades

:heavy_check_mark: `Funcionalidade 1:` Cadastrar novos produtos no estoque.

:heavy_check_mark: `Funcionalidade 2:` Atualizar informações de produtos existentes.

:heavy_check_mark: `Funcionalidade 3:` Excluir produtos do estoque.

:heavy_check_mark: `Funcionalidade 4:` Listar todos os produtos, organizados por categorias e prateleiras.

:heavy_check_mark: `Funcionalidade 5:` Documentação automática da API com Swagger.

## Tecnologias utilizadas

| Tecnologia/Biblioteca | Versão | Link |
|-----------------------|--------|------|
| .NET 8                | 8.0    | [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) |
| Entity Framework Core | 8.0.8  | [EF Core](https://learn.microsoft.com/en-us/ef/core/) |
| Pomelo.EntityFrameworkCore.MySql | 8.0.2 | [Pomelo EF Core MySQL](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) |
| Swashbuckle.AspNetCore | 6.7.0 | [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) |

## Acesso ao projeto

Você pode [acessar o código fonte do projeto](https://github.com/seu-usuario/seu-repositorio) ou [baixá-lo](https://github.com/seu-usuario/seu-repositorio/archive/refs/heads/main.zip).

## Abrir e rodar o projeto

Siga os passos abaixo para configurar e executar o projeto localmente:

### Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) ou outro banco de dados compatível com EF Core
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

### Passo a Passo

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/victoroliveira59/APICatalogo.git
   cd seu-repositorio
   ```

2. **Configure o banco de dados**:
   - Abra o arquivo `appsettings.json` e atualize a string de conexão com as credenciais do seu banco de dados MySQL.
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=estoque;User=root;Password=sua_senha;"
   }
   ```

3. **Execute as migrações**:
   - No terminal, execute o seguinte comando para aplicar as migrações e criar o banco de dados:
   ```bash
   dotnet ef database update
   ```

4. **Execute o projeto**:
   - No terminal, execute:
   ```bash
   dotnet run
   ```
   - Ou, no Visual Studio, pressione `F5` para iniciar a depuração.

5. **Acesse a API**:
   - A API estará disponível em `http://localhost:5000` ou `https://localhost:5001`.
   - Para explorar os endpoints, acesse a interface do Swagger em `http://localhost:5000/swagger`.

## Desenvolvedor

<p align="ligth">
   <a href="https://github.com/victoroliveira59">
      <img src="https://img.icons8.com/ios-glyphs/30/000000/github.png" alt="GitHub icon"/>
      <br>
      <sub>Victor Oliveira</sub>
   </a>
</p>

