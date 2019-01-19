# Copa Filmes
A Copa do mundo de filmes funciona da seguinte maneira: uma lista inicial de 8 filmes é
selecionada e, dentre esses filmes, são realizadas partidas para verificar quem é o vencedor.
Para montar esse chaveamento será necessário ordená-los por ordem alfabética e o filme
na primeira posição disputa contra o filme da última posição, o segundo com o penúltimo e
assim por diante. 

## Executando a aplicação
Utilizando um terminal navegue até para a pasta o diretório onde a aplicação foi baixada até a pasta "CopaFilmes/ClientApp" e execute o comando "npm install" para instalar as dependências do frontend e "ng build" para compilar o projeto angular:
```
c:\CopaFilmes\CopaFilmes\ClientApp npm install

c:\CopaFilmes\CopaFilmes\ClientApp ng build
```


Após compilar a aplicação angular, volte para o diretório acima, na pasta "CopaFilmes" e execute o comando "dotnet run" como no exemplo abaixo:
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

### asp.net core
Para executar os testes da aplicação asp.net core, navegue até o diretório raiz do projeto e execute o comando "dotnet test" como no exemplo abaixo:
```
c:\CopaFilmes dotnet run
```

Ao executar este comando o testes unitários serão executados e os seguintes logs deverão ser apresentados:
```
Build started, please wait...
Skipping running test for project C:\Users\feoku\Development\test\CopaFilmes\CopaFilmes\CopaFilmes.csproj. To run tests with dotnet test add "<IsTestProject>true<IsTestProject>" property to project file.
Build completed.

Test run for C:\Users\feoku\Development\test\CopaFilmes\CopaFilmesTest\bin\Debug\netcoreapp2.1\CopaFilmesTest.dll(.NETCoreApp,Version=v2.1)
Microsoft (R) Test Execution Command Line Tool Version 15.9.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 3. Passed: 3. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 3.3251 Seconds
```

### angular 6
Para executar os testes unitários do frontend, navegue até o diretório "ClientApp" e execute o comando "ng test" como no exemplo abaixo:
```
c:\CopaFilmes\CopaFilmes\ClientApp ng test
```

Ao executar este comando, será aberto o browser para as simulações dos testes no frontend. Os resultados são apresentados no terminal e no browser. 

```
10% building modules 1/1 modules 0 active(node:10996) DeprecationWarning: Tapable.plugin is deprecated. Use new API on `.hooks` instead
19 01 2019 02:10:48.732:WARN [karma]: No captured browser, open http://localhost:9876/
19 01 2019 02:10:48.756:INFO [karma]: Karma v1.7.1 server started at http://0.0.0.0:9876/
19 01 2019 02:10:48.756:INFO [launcher]: Launching browser Chrome with unlimited concurrency
19 01 2019 02:10:48.766:INFO [launcher]: Starting browser Chrome                                                                19 01 2019 02:10:55.682:WARN [karma]: No captured browser, open http://localhost:9876/
19 01 2019 02:10:56.525:INFO [Chrome 71.0.3578 (Windows 10.0.0)]: Connected on socket iBgb42Y3-mtsVO5GAAAA with id 68746801
Chrome 71.0.3578 (Windows 10.0.0): Executed 8 of 8 SUCCESS (0.374 secs / 0.347 secs)
```