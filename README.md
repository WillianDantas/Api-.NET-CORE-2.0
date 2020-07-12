# Desafio para vaga de desenvolvedor da Perlink

## Considerações Gerais

* Sua solução poderá ser desenvolvida em dotnet core 2.1+ ou dotnet framework 4.7+.

* Devemos ser capazes de executar sua solução em nossa máquina rodando windows 10.

* No seu README, você deverá fazer uma explicação sobre a solução encontrada, tecnologias envolvidas e instrução de uso da solução. 

* É interessante que você também registre ideias que gostaria de implementar caso tivesse mais tempo.

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

## Requisitos

* Sua solução deverá ser capaz de armazenar os processos recebidos.

* Considere um número de inserções de 100 processos/sec. Cada escritório envia um processo no momento em que ele for criado, então um escritório não pode enviar um processo com o mesmo número duas vezes.

* Para visualização desses dados, sua solução deve possuir:
    * Uma tabela que mostre todos os processos recebidos. Essa tabela deve ser atualizada automaticamente.
    * Um gráfico para processos agrupados por escritório.

* Para seu cliente, é muito importante que ele saiba o número de processos recebidos por escritório.

## Avaliação

Nossa equipe irá avaliar código, simplicidade da solução, testes unitários, arquitetura e automatização de tarefas.

Em caso de dúvida, entre em contato com o responsável pelo seu processo seletivo.
