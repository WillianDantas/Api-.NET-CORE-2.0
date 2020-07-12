# Desenvolvimento de uma Api em  dotnet core 2.1+


## Problema

Imagine que você ficou responsável por construir um sistema que seja capaz de receber milhares de dados por segundo de processos de escritórios jurídicos espalhados pelo Brasil. Seu cliente também deseja que na solução ele possa visualizar esses processos de forma clara.

Um processo é defino por um JSON com o seguinte formato:

```json
{
   "numeroDoProcesso": "<string>",
   "dataDeCriacaoDoProcesso": <DateTime>,
   "valor": <decimal>
   "escritorio" : "<string>"
}
```

Descrição:
 * O campo numeroDoProcesso é o número do processo criado.
 * A DataDeCriacaoDoProcesso é a data em que o processo foi aberto na justiça, sendo composto por letras e números.
 * O valor é a quantia cobrada de indenização no processo.
 * O Escritorio é o nome do escritório que fez o envio para a API.


* Para visualização desses dados, sua solução deve possuir:
    * Uma tabela que mostre todos os processos recebidos. Essa tabela deve ser atualizada automaticamente.
    * Um gráfico para processos agrupados por escritório.

* Para seu cliente, é muito importante que ele saiba o número de processos recebidos por escritório.


