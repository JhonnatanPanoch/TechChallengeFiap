# TechChallengeFiap

Sistema de gerenciamento de pedidos e produtos para uma plataforma de venda de jogos digitais e gestão de servidores para partidas online, desenvolvido como parte do Tech Challenge da FIAP.

---

## Índice

- [Sobre o Projeto](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#sobre-o-projeto)
- [Documentação](https://github.com/user-attachments/files/20558034/TC.NETT.-.Fase.1.pdf)
- [Tecnologias Utilizadas](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#tecnologias-utilizadas)
- [Estrutura do Projeto](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#estrutura-do-projeto)
- [Endpoints](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#endpoints)
- [Configuração e Execução](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#configura%C3%A7%C3%A3o-e-execu%C3%A7%C3%A3o)
- [Testes](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#testes)
- [Licença](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#-licen%C3%A7a)
- [Autores](https://github.com/JhonnatanPanoch/TechChallengeFiap/blob/main/README.md#autores)

---

## Sobre o Projeto

O **TechChallengeFiap** é uma aplicação web desenvolvida com .NET 8, seguindo os princípios de Clean Architecture e Domain-Driven Design (DDD).  
O sistema permite que clientes realizem pedidos, consultem produtos e acompanhem o status de suas solicitações.  
Além disso, oferece funcionalidades para gerenciamento de produtos e pedidos por parte dos administradores da lanchonete.

---

## Tecnologias Utilizadas

- [ASP.NET Core 8](https://learn.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core)
- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)
- [PostgreSQL](https://www.postgresql.org/)
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- [Swagger](https://swagger.io/)
- [JWT Authentication](https://jwt.io/)
- [xUnit](https://xunit.net/)

---

## Estrutura do Projeto

```text
TechChallengeFiap/
├── Fcg.Application/         # Camada de aplicação com serviços e DTOs
├── Fcg.Domain/              # Entidades e interfaces de domínio
├── Fcg.Infra/               # Implementações de repositórios e contexto do EF Core
├── Fcg.API/                 # API RESTful com controllers e middlewares
├── Fcg.Test/                # Testes automatizados
├── docker-compose-local.yml
├── Dockerfile
├── README.md
└── LICENSE
```

---

## Endpoints 

| Área       | Método e Endpoint              | Autorização       |
|------------|-------------------------------|-------------------|
| Auth       | POST /api/v1/Auth/entrar       | Sem autenticação  |
| Auth       | POST /api/v1/Auth/registrar    | Sem autenticação  |
|------------|-------------------------------|-------------------|
| Compras    | POST /api/v1/Compras/jogos     | Role Usuario |
|------------|-------------------------------|-------------------|
| Conta      | GET /api/v1/Conta              | Role Usuario |
| Conta      | PUT /api/v1/Conta              | Role Usuario |
| Conta      | DELETE /api/v1/Conta           | Role Usuario |
|------------|-------------------------------|-------------------|
| Jogos      | GET /api/v1/Jogos             | Role Usuario |
| Jogos      | GET /api/v1/Jogos/{id}         | Role Usuario |
| Jogos      | POST /api/v1/Jogos             | Role Admin        |
| Jogos      | PUT /api/v1/Jogos/{id}         | Role Admin        |
| Jogos      | DELETE /api/v1/Jogos/{id}      | Role Admin        |
|------------|-------------------------------|-------------------|
| Promocoes | GET /api/v1/Promocoes          | Role Usuario |
| Promocoes | GET /api/v1/Promocoes/{id}     | Role Usuario |
| Promocoes | DELETE /api/v1/Promocoes/{id}  | Role Admin        |
| Promocoes | POST /api/v1/Promocoes         | Role Admin        |
|------------|-------------------------------|-------------------|
| Usuario   | GET /api/v1/Usuario            | Role Admin        |
| Usuario   | GET /api/v1/Usuario/{id}       | Role Admin        |
| Usuario   | PUT /api/v1/Usuario/{id}       | Role Admin        |
| Usuario   | DELETE /api/v1/Usuario/{id}    | Role Admin        |
| Usuario   | PUT /api/v1/Usuario/{id}/role  | Role Admin        |


---


## Configuração e Execução

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Passos para executar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/JhonnatanPanoch/TechChallengeFiap.git
cd TechChallengeFiap
```

2. Inicie os containers com Docker Compose:

```bash
docker-compose -f docker-compose-local.yml up --build
```

3. Acesse a aplicação:

- API: [http://localhost:5000](http://localhost:5000)  
- Swagger: [http://localhost:5000/swagger](http://localhost:5000/swagger)

_Observações:_ 
- O Projeto usa EF Core com Migrations configuradas a nível de código, então, a execução do `docker-compose` é sficiente para criação de toda infraestrutura do banco de dados e da api 
- Foram criados seeders na aplicação com dados iniciais, para testes:
  
  |Role|Email|Senha|
  |-|-|-|
  |Default User|defuser@gmail.com|User@123|
  |Admin User|defadminser@gmail.com|Admin@123|

---

## Testes

Para executar os testes unitários:

```bash
dotnet test
```

Os testes estão localizados no projeto `Fcg.Test` e cobrem os principais serviços e repositórios da aplicação.

---

## 📄 Licença

Este projeto está licenciado sob a MIT License.

---

## Autores

**Jhonnatan Panoch**

- [GitHub](https://github.com/JhonnatanPanoch)
- [LinkedIn](https://www.linkedin.com/in/jhonnatanpanoch)

**Marcos Lancy**

- [GitHub](https://github.com/marcos-lancy)
- [LinkedIn](https://www.linkedin.com/in/marcos-w-a99362141/)
