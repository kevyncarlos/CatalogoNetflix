# CATÁLOGO NETFLIX

### Aplicação composta por dois projetos
* Executor: Responsável por ler um CSV, converter para JSON e enviar para uma API.
* WebAPI: Responsável por receber os dados em JSON e persistir no banco de dados, além de retornar informações por métodos GET.

### Como executar?
1. Executar primeiramente a API, nesse momento o banco será criado e ela estará pronta para receber dados;
2. Executar o console para ler o CSV e enviar os dados;
3. Testar a API no navegador;

### Rotas
>Base: http://localhost:5000

ROTA | DADOS | OBSERVAÇÃO | EXEMPLO
--- | :---: | --- | ---
`/api/catalogo` | - | Lista todos os filmes do catálogo | -
`/api/catalogo/{id}` | \{id\} = inteiro | Lista um filme pelo identificador (ID) | `/api/catalogo/1`
`/api/catalogo/search/{title}` | \{title\} = string | Lista todos os filmes que contenham uma palavra no título | `/api/catalogo/search/great`