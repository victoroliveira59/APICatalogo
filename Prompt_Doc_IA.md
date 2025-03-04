 Contexto:
	O meu projeto é um projeto de estudo que consiste em aprender as técnicas para criar APIS com .NET 8, esse é um projeto de um curso da udemy.
	O projeto consiste no gerenciamento de estoque de produtos , onde é possível cadastrar, atualizar, deletar e listar produtos, e organizar por categorias ,
	e por prateleiras. As tecnologias usadas nesse projeto são:
	        <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <UserSecretsId>4b14c919-394c-4046-8a3c-629b1cbf7e0f</UserSecretsId>
  </PropertyGroup>


  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="8.0.8" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.8">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.8">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="8.0.4" />
    <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.7.0" />
  </ItemGroup>

</Project>

Regras:
- Adicionar Hiperlinks para as tecnologias usadas no projeto.
- Organize as dependencias em formato de tabela
- A partir da estrutura que está o meu projeto identifique qual metodo foi realizado para cria-lo:

Mode                LastWriteTime         Length Name
----                -------------         ------ ----
d-----       06/09/2024     10:54                  bin
d-----       16/12/2024     19:47                  Context
d-----       22/01/2025     08:54                  Controllers
d-----       17/09/2024     15:37                  Extensions
d-----       17/09/2024     15:37                  Filters
d-----       22/01/2025     08:16                  Interface
                      d-----       23/12/2024     21:15                  Migrations
d-----       23/12/2024     21:16                  Models
d-----       17/09/2024     14:42                  NovaPasta
d-----       17/09/2024     14:42                  NovaPasta1
d-----       04/03/2025     10:51                  obj
d-----       06/09/2024     10:54                  Properties
d-----       22/01/2025     08:38                  Repository
-a----       23/12/2024     21:17            611   .gitignore
-a----       17/09/2024     15:37           1250   APICatalogo - Backup.csproj
-a----       16/12/2024     18:24           1541   APICatalogo.csproj
-a----       09/09/2024     14:43            543   APICatalogo.csproj.user
-a----       06/09/2024     10:54            135   APICatalogo.http
-a----       06/09/2024     10:54            127   appsettings.Development.json
-a----       23/12/2024     21:20            229   appsettings.json
-a----       22/01/2025     08:38           2154 󰌛  Program.cs


Adicionando Informações:
    Crie o passo a passo da instalação e execução do projeto.

