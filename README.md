# Copa Filmes
A Copa do mundo de filmes funciona da seguinte maneira: uma lista inicial de 8 filmes é
selecionada e, dentre esses filmes, são realizadas partidas para verificar quem é o vencedor.
Para montar esse chaveamento será necessário ordená-los por ordem alfabética e o filme
na primeira posição disputa contra o filme da última posição, o segundo com o penúltimo e
assim por diante. 

## Executando a aplicação
Utilizando um terminal navegue até para a pasta o diretório onde a aplicação foi baixada até a pasta "CopaFilmes" e execute o comando "dotnet run" como no exemplo abaixo:
```
c:\CopaFilmes\CopaFilmes dotnet run
```
Ao executar este comando, aguarde até que o terminal apresente os logs informando que a aplicação está sendo executada e ouvindo a porta 5001 como abaixo:

```
Hosting environment: Production
Content root path: C:\Users\feoku\Development\CopaFilmes\CopaFilmes
Now listening on: http://localhost:5000
Now listening on: https://localhost:5001
Application started. Press Ctrl+C to shut down.
```

Apartir deste momento, utilizando um browser, acesse a url "https://localhost:5001". Caso seja pedido, autorize o endereço na lista de sites confiáveis. 

Com a aplicação em execução, selecione 8 filmes para que o botão de execução do campeonado seja habilitado. 

Ao executar o comando para gerar o campeonato, um lista com o resultado será apresentado. E é isso!!


## Execução dos testes unitários
Os testes unitários garantem que cada método esteja funcionando como o esperado e, caso algum método não se comporte como o esperado, é possível identificar com mais rapidez e precisão. 
