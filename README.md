
# Compiladores - Trabalho Final </>

**Interpretador ProdyC**

Este projeto consiste em um interpretador para uma linguagem de programação fictícia chamada "ProdyC". A linguagem ProdyC foi projetada para ser simples e educativa, oferecendo suporte a estruturas de controle, funções, entrada/saída e operações matemáticas.


### Tecnologias Usadas

- C#
- Antlr4

### Referências 

- C
- Python
- [wellingtondellamura/compilers-final-work](https://github.com/wellingtondellamura/compilers-final-work)
## Documentação

Documentação da gramática da linguagem 

### Símbolos Não-Terminais

```
prog: Representa o programa principal.
functions: Lista de funções no programa.
function: Definição de uma função.
fnBlock: Bloco de uma função.
fnBody: Corpo de uma função.
params: Parâmetros de uma função.
line: Linha de código.
funcInvoc: Chamada de função.
stmt: Declaração de instrução.
input: Instrução de entrada.
output: Instrução de saída.
tipo: Tipo de dado.
ifst: Instrução condicional if.
whilest: Instrução de loop while.
forst: Instrução de loop for.
block: Bloco de código.
cond: Expressão condicional.
atrib: Atribuição de valor.
expr: Expressão aritmética.
term: Termo na expressão aritmética.
factor: Fator na expressão aritmética.
```
### Símbolos Terminais

```
OE: '('
CE: ')'
OB: '{'
CB: '}'
AT: '='
SEP: ','
PLUS: '+'
MINUS: '-'
MULT: '*'
DIV: '/'
AND: '&&'
OR: '||'
NOT: '!'
EQ: '=='
LT: '<'
GT: '>'
LE: '<='
GE: '>='
NE: '!='
BOOL_TRUE: 'true'
BOOL_FALSE: 'false'
IF: 'if'
WHILE: 'while'
DO: 'do'
FOR: 'for'
FUNCTION: 'function'
RETURN: 'return'
THEN: 'then'
ELSE: 'else'
WRITE: 'write'
READ: 'read'
STR: String literal
EOL: ';'
NUM: Número inteiro
VAR: Identificador de variável
COMMENT: Comentário de uma linha
WS: Espaço em branco
```
## Regras Gramaticais 

__Programa principal__
```
prog: functions line+
```
__Funções__

```
functions: function functions
         |
```

__Definição de Função__

```
function: FUNCTION VAR '(' params ')' fnBlock;
```

__Bloco de Função__

```
fnBlock: '{' fnBody '}'
```

__Corpo das Funções__

```
fnBody: line
      | line fnBody
      | RETURN expr EOL
      | RETURN EOL

```

__Parâmetros de Função__

```
params: VAR
      | VAR SEP params
      |

```

__Declaração de Instrução__

```
stmt: atrib
     | input
     | output
     | funcInvoc

```

__Instruções de Entrada__

```
input: tipo READ VAR
```

__Instruções de Saída__

```
output: WRITE VAR
       | WRITE STR
       | WRITE expr

```

__Tipos de Dados__

```
tipo: 'int'
     | 'string'
     | 'float'
     | 'bool'

```

__Estrutura Condicional__

```
ifst: IF '(' cond ')' THEN block
    | IF '(' cond ')' THEN b1=block ELSE b2=block

```

__Instrução de Loop (While)__

```
whilest: WHILE '(' cond ')' block
        | DO block WHILE '(' cond ')'

```

__Instrução de Loop (For)__

```
forst: FOR '(' atrib? ';' cond? ';' atrib? ')' block
```

__Bloco de Código__

```
block: '{' line+ '}'
```

__Expressões Condicionais__

```
cond: expr
     | e1=expr RELOP=(EQ|NE|LT|GT|LE|GE) e2=expr
     | c1=cond AND c2=cond
     | c1=cond OR c2=cond
     | NOT cond

```

__Atribuição de Valor__

```
atrib: tipo VAR '=' expr
      | tipo VAR '=' STR

```

__Expressões Aritméticas__

```
expr: term '+' expr
    | term '-' expr
    | term

```

__Termo na Expressão Aritmética__

```
term: factor '*' term
    | factor '/' term
    | factor

```

__Fator na Expressão Aritmética__

```
factor: '(' expr ')'
       | VAR
       | NUM
```

__Regras Léxicas__

```
OE: '(';
CE: ')';
OB: '{';
CB: '}';
AT: '=';
SEP: ',';
PLUS: '+';
MINUS: '-';
MULT: '*';
DIV: '/';
AND: '&&';
OR: '||';
NOT: '!';
EQ: '==';
LT: '<';
GT: '>';
LE: '<=';
GE: '>=';
NE: '!=';
BOOL_TRUE: 'true';
BOOL_FALSE: 'false';
IF: [iI][fF];
WHILE: [wW][hH][iI][lL][eE];
DO: [dD][oO];
FOR: [fF][oO][rR];
FUNCTION: [fF][uU][nN][cC][tT][iI][oO][nN];
RETURN: [rR][eE][tT][uU][rR][nN];
THEN: [tT][hH][eE][nN];
ELSE: [eE][lL][sS][eE];
WRITE: [wW][rR][iI][tT][eE];
READ: [rR][eE][aA][dD];
STR: '"' ~["]* '"';
EOL: ';';
NUM: [0-9]+ (.([0-9]+))?;
VAR: [a-zA-Z_][a-zA-Z0-9_]*;
COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;
```
## Uso e Exemplos

__Como usar:__ 
```
git clone https://github.com/MelissaOliveiraC/compiladores-trabalho-final.git
```

### __Exemplos__ 

__Exemplo 1__

Código colocado no arquivo *input.ProdyC*
```
function main() {
    int x = 5;
    int y = 10;
    int result = x + y;
    write result;
};
```
Resultado (Terminal)

<a href="https://imgur.com/GiLr2Xo"><img src="https://i.imgur.com/GiLr2Xo.png" title="source: imgur.com" /></a>


__Exemplo 2__

Código colocado no arquivo *input.ProdyC*
```
write "Verificacao de tipo"; 
write "digite algo: ";
int read a;
```
Resultado (Terminal)

<a href="https://imgur.com/Fjd1Per"><img src="https://i.imgur.com/Fjd1Per.png" title="source: imgur.com" /></a>
<br/>
<a href="https://imgur.com/T55tTsV"><img src="https://i.imgur.com/T55tTsV.png" title="source: imgur.com" /></a>


__Exemplo 3__

Código colocado no arquivo *input.ProdyC*
```
function main() {
    for (int i = 0;i < 5; int i = (i + 1)) {
          int x = 10;
          //write x + i;
        }
    return 0;
};
```
Resultado (Terminal)

<a href="https://imgur.com/TOF9TOU"><img src="https://i.imgur.com/TOF9TOU.png" title="source: imgur.com" /></a>

__Exemplo 4__

Código colocado no arquivo *input.ProdyC*
```
float x = 2.5;
int y = 2;
string str = "ola";
```
Resultado (Terminal)

<a href="https://imgur.com/TOF9TOU"><img src="https://i.imgur.com/TOF9TOU.png" title="source: imgur.com" /></a>

__Exemplo 5__

Código colocado no arquivo *input.ProdyC*
```
function fat (fator, n){

      for (int i = 1;i <= n; int i = (i + 1)) {
          int fator = fator * i;
        }

      write fator;
};
```
Resultado (Terminal)

<a href="https://imgur.com/TKHJjEM"><img src="https://i.imgur.com/TKHJjEM.png" title="source: imgur.com" /></a>

__Exemplo 6 - presente no arquivo *input.ProdyC* ao baixar__

Código colocado no arquivo *input.ProdyC*
```
function main() {
    // declaração de variáveis e operação básica com escrita no terminal result é 15

    int x = 5;
    int y = 10;
    int result = x + y;
    write result;



    // estrutura de loop para realizar operação básica

    for (int i = 0;i < 5; int i = (i + 1)) {
          int x = 10;
          write x + i;
    }




    // declaração de alguns dos outros tipos suportados pela linguagem ProdyC

    float x = 2.5;
    int y = 3;
    string str = "ola";




    // verificação de condição y é igual a 2

    if(y == 2) then {
        write "verdadeiro, y é 2";
    } else {
        write "falso, y não é igual 2";
    }




    // verificação de tipo, aceita apenas "int" pois 'a' é um int

    write "| Vamos verificar o tipo!"; 
    write "digite algo: ";
    int read a;
    



    // precedência 100 * 2 = 200 + y --> 202

    int res = y + 100 * 2;
    write res;

    return 0;
};
```
Resultado (Terminal)

<a href="https://imgur.com/5mUjtcY"><img src="https://i.imgur.com/5mUjtcY.png" title="source: imgur.com" /></a>
## Métodos e Técnicas

* __ANTLR (ANother Tool for Language Recognition):__ O Antlr4 foi empregado para criar o lexer e parser da linguagem ProdyC. Isso facilita a análise léxica e sintática do código fonte, gerando uma árvore de análise sintática que serve como base para a interpretação.

* __Árvore de Análise Sintática:__ Após a análise léxica e sintática, uma árvore de análise sintática é construída. Essa árvore representa a estrutura hierárquica do código fonte e é usada como base para a interpretação das instruções.

* __Padrão Visitor para Interprete:__ O interpretador utiliza o padrão de design Visitor, fornecido pelo Antlr, para percorrer a árvore de análise sintática e interpretar as instruções. Cada tipo de nó na árvore possui um método correspondente no interpretador.

* __Dicionário de Funções:__ O interpretador mantém um dicionário de funções, onde cada função é associada a sua definição na árvore de análise sintática. Isso permite a chamada de funções durante a execução do programa.

* __Manipulação de Variáveis:__ O interpretador rastreia as variáveis e seus valores durante a execução do programa. As variáveis são armazenadas em um dicionário para fácil acesso e atualização.

* __Entrada e Saída:__ Suporte à entrada (read) e saída (write) é implementado para interagir com o usuário durante a execução do programa.

## Descrição de Imprementação

__ProdyCInterpreter__

Esta classe representa o interpretador para a linguagem ProdyC. 

* _Aqui estão algumas características principais:_

_Variáveis e Funções:_

 * Mantém um dicionário de variáveis (Variables) para armazenar valores de variáveis durante a execução.
* Possui um dicionário _functions para armazenar as árvores de análise sintática das funções.

_Entrada e Saída (I/O):_

* Implementa métodos para lidar com comandos de entrada e saída.

_Operações Matemáticas:_

* Trata expressões matemáticas, atribuições e outras operações relacionadas a variáveis.

_Controle de Fluxo:_

* Implementa instruções de controle de fluxo, como if, else, while, do-while e for.

_Funções:_

* Suporta a invocação de funções definidas na linguagem ProdyC através do método VisitFuncInvocLine.


__ProdyCErrorListener__

Esta classe estende BaseErrorListener e é um ouvinte de erros personalizado para a linguagem ProdyC. 

* _Aqui estão algumas características principais:_

* Mantém um indicador HasErrors para rastrear se ocorreram erros durante a análise.

* Armazena mensagens de erro em uma lista ErrorMessages para referência.

__SemanticProdyCListener__

Esta classe estende ProdyCBaseListener e é um ouvinte semântico para a linguagem ProdyC. 

* _Aqui estão algumas características principais:_

* Mantém um dicionário de funções (Functions) e um conjunto de variáveis (Variables).
* Verifica se uma variável é declarada antes de ser usada.
* Verifica se uma função é declarada corretamente.
* Estende o método ExitFunction para verificar a declaração correta de funções.

Essas classes trabalham em conjunto para interpretar código-fonte ProdyC, gerenciar variáveis, lidar com entrada/saída e garantir a correção semântica durante a análise.
