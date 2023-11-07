# MyClasses

Este projeto contém uma classe chamada `FileProcess` que fornece métodos relacionados a processamento de arquivos.

## FileProcess

A classe `FileProcess` contém o seguinte método:

### `bool FileExists(string fileName)`

Verifica se um arquivo com o nome especificado existe.

- `fileName` (string): O caminho e nome do arquivo a ser verificado.

    Retorna `true` se o arquivo existir e `false` se não existir.

## MyClassesTest

Este projeto contém testes unitários para a classe `FileProcess`.

## Configurações

Este projeto utiliza o MSTest para execução dos testes.

## Testes Incluídos

### `FileNameDoesExists`

- Descrição: Verifica se um arquivo existe.
- Categoria: NoException

### `FileNameDoesExistsUsingDeploymentItem`

- Descrição: Verifica se um arquivo existe usando DeploymentItem.
- Categoria: NoException

### `SimulateTimeOut`

- Descrição: Simula um timeout.
- Categoria: NoException

### `FileNameDoesNotExists`

- Descrição: Verifica se um arquivo não existe.
- Categoria: NoException

### `FileNameNullOrEmpty_throwsArgumentNullException`

- Descrição: Verifica se uma exceção `ArgumentNullException` é lançada ao fornecer um nome de arquivo nulo ou vazio.
- Categoria: Exception

### `FileNameNullOrEmpty_throwsArgumentNullException_UsingTryCatch`

- Descrição: Verifica se uma exceção `ArgumentNullException` é lançada ao fornecer um nome de arquivo nulo ou vazio usando bloco try-catch.
- Categoria: NoException

## Executando os Testes

1. Abra o projeto em seu ambiente de desenvolvimento.
2. Abra o explorador de testes ou terminal e execute os testes.

## Contribuindo

Se você gostaria de contribuir para o desenvolvimento deste projeto, fique à vontade para abrir um pull request.

## Licença

Este projeto está sob a [licença MIT](LICENSE).
