# CAT�LOGO NETFLIX

### Aplica��o composta por dois projetos
* Executor: Respons�vel por ler um CSV, converter para JSON e enviar para uma API.
* WebAPI: Respons�vel por receber os dados em JSON e persistir no banco de dados, al�m de retornar informa��es por m�todos GET.

### Como executar?
1. Executar primeiramente a API, nesse momento o banco ser� criado e ela estar� pronta para receber dados;
2. Executor o console para ler o CSV e enviar os dados;
3. Testar a API no navegador;

### Rotas
>Base: http://localhost:5000

ROTA | DADOS | OBSERVA��O
--- | :---: | ---
`/api/catalogo` | - | Lista todos os filmes do cat�logo
`/api/catalogo/{id}` | \{id\} = inteiro | Lista um filme pelo identificador (ID)
`/api/catalogo/search/{title}` | \{title\} = string | Lista todos os filmes que contenham uma palavra no t�tulo