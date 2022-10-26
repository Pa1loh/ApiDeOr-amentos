<h1>API de Orçamentos</h1> 




> Status do Projeto: Em desenvolvimento :warning: 

### Tópicos 

:small_blue_diamond: [Descrição do projeto](#descrição-do-projeto)

:small_blue_diamond: [Próximos passos](#próximos-passos)

:small_blue_diamond: [Desenvolvimento e Aprendizado](#descrição-do-projeto)

:small_blue_diamond: [Funcionalidades](#funcionalidades)

:small_blue_diamond: [Deploy da Aplicação](#deploy-da-aplicação)

:small_blue_diamond: [Pré-requisitos](#pré-requisitos)

:small_blue_diamond: [Como rodar a aplicação](#como-rodar-a-aplicação)

## Descrição do projeto 

<p align="justify">
Esta Api surgiu para resolver problemas do meu pai, como ele é Engenheiro civil sempre me disse o problema que é fazer um orçamento para uma obra,
com isso ele me contava sua expêriencias na decâda de 90 com softwares que faziam isso porem o trabalho que dava e a demora.
Logo está API surgiu como parte de uma solução para a criação de um software para Orçamento.
O objetivo deste software é resolver o problema de Engenheiros de qualquer área com crud de insumos e gerenciamento de orçamentos.

Para consumir essa api será desenvolvido um front-end em React e logo seu repositório estará
</p>

## Próximos passos

- Documentação e Implementação de cada camada da API (MODELS, REPOSITORY, SERVICE, CONTROLLER)
- Certificação das Normas do Projeto (Clean Code, Rest, DDD)
- Cobrir 100% da Aplicação com testes
- Lançar a V1
- Implementação do Git Flow com brenchs, commits e Tasks
- Implementar o TDD
- Verificar Possiveis novas funcionalidades
- fazer a integração com um front-end



## Desenvolvimento e Aprendizado

:heavy_check_mark: Aprender e Desenvolver uma API REST

:heavy_check_mark: Aplicar aprendizados do livro Código Limpo

:warning:  Documentar End-Points

:warning:  Utilizar DDD

:warning:  Em futuras implementações utilizar TDD

:warning:  Documentar API com Casos de Uso

:warning:  Documentar API com Diagrama de Clases

:warning:  Documentar API com DER e MER

## Funcionalidades

:heavy_check_mark: Cadastros: de mão de obra  insumos  Composição e empresa  usuário  cliente e orçamentos.

:heavy_check_mark: Gerenciamento de estoque e preço.

:heavy_check_mark: Orçamento da Obra.

:heavy_check_mark: Consulta e exclusão.

## Deploy da Aplicação

Como a API tem o objetivo inicial de aprendizagem, o Deploy sera feito em plataforma free e sem pensar em expansão em primeiro momento, junto ao objetivo do deploy sem compromisso de expansão vem a validação da API.
Após a validação e estudo de sua escabilidade o deploy pode e deve ser mudado para um ambiente que suporte todas requisições.

## Pré requisitos

Atualmente como esta em fase de densvolvimento os pré requisitos são minimos:

- Clonar o Projeto
```
git clone https://github.com/Pa1loh/ApiDeOrcamentos.git
```
- Abrir em IDE com suporte ao [.Net6](<https://dotnet.microsoft.com/en-us/download/dotnet/6.0>) (Recomendo [Visual Studio 2022](<https://visualstudio.microsoft.com/pt-br/vs/>))
- Executar o comando no console nugget o seguinte comando, para gerar o banco de dados
```
Update-Database
````
- Ao rodar a aplicação a documentação irá abrir com o Swagger:

  <https://localhost:7052/swagger>

## Como Rodar A Aplicação

- Executar o comando no console nugget o seguinte comando, para gerar o banco de dados
```
dotnet run
```

## Licença 

The [MIT License]() (MIT)

Copyright :copyright: 2011 - Api Orçamento ORCe



