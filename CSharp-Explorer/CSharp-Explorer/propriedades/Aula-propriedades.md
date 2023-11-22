# Explorando o C#

## propriedades
Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou caluclar o valor de um campo 
particular.

por exemplo:

##### Pessoa
- Nome: String;
- Idade: Number;
#### Regras
Em nossa classe podemos receber o Get e o Set vazios e isso pode gerar um erro no nosso program e logo em seguida se 
encerrar.
Podemos criar para a nossa classe validações para evitar esses erros.

Vamos colocar algumas regras para a nossa classe pessoa:
- O nome não pode ser vazio;
- O nome deve ser imprimido em maiusculo.
- Idade nãp pode ser menor do que -1;

## Modificadore de acesso
- private -> Acessível apenas dentro da classe (protegida acessada apenas de uma propriedade/método).
- public -> Acessível por qualquer classe externa.
- protect => Acessível apenas para classes dentro do mesmo escopo

### Propriedade apenas para leitura
São propriedades que tem apenas o método get.

vamos criar uma propriedade sobrenome.

## Métodos
Um método é um bloco de código que contém uma série de instruções. Ou seja, ele é uma ação/comportamento.

vamos criar uma classe Curso que vai conter objetos do tipo pessoas e alguns métodos.

##### Curso
- Nome: string;
- Alunos: List< Pessoa>;
- _Métodos_:
  - AddAluno();
  - RemoveAluno();
  - ListarAlunos();
  - ObterQuantidadeDeAlunosmatriculados();

## Construtores
Os contrutores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e 
fáceis de ler.