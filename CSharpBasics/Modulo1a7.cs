/*
==========VARIAVEIS===============
int idade = 30;
long cnpj = 1234567;
string nome = "Matheus";
char flag = 's';
bool ativo = true;
const string descricao =  "Faz o curso";

decimal valor = 200.99m;
double valorDouble = 200.99;
double vlaorFloat = 200.99f;

Console.WriteLine(nome);
Console.WriteLine(cnpj);
Console.WriteLine(idade);
Console.WriteLine(flag);
Console.WriteLine(ativo);
Console.WriteLine(descricao);
*/

/*
===============OPERAÇÕES==================
int num1 = 2;
var num2 = 4;

var soma = num1 + num2;
var subtracao = num2 - num1;
var multiplicacao = num1 * num2 * 5;
var divisao = num2 / num1;


Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

bool igual = num1 == num2;
Console.WriteLine(igual);

bool maior = num2 > num1;
Console.WriteLine(maior);

bool menor = num2 < num1;
Console.WriteLine(menor);

bool diferente = num2 != num1;
Console.WriteLine(diferente);

bool valido = num2 > num1 && 10 < 5;
Console.WriteLine(valido);

bool valido2 = num2 < num1 || 10 > 5;
Console.WriteLine(valido2);

bool valido3 =  !(10 > 5);
Console.WriteLine(valido3);

===========TERNARIO================

bool ativo = true;

string status = ativo ? "Cadsatro Ativo" : "Cadastro Inativo";

Console.WriteLine(status);*/

/*
=========FUNÇÕES===============
var nome = NomeCompleto();

Console.WriteLine(nome);

string NomeCompleto()
{
    return "Matheus Muruci";
}

int soma = SomaValores(5, 2);
Console.WriteLine(soma);

int SomaValores(int a, int b)
{
    return a + b;
}
*/

using System.Collections;

// =========ESTRUTURA DE DADOS============

/*
==========ARRAY===========


var array = new ArrayList();

array.Add(1);
array.Add("Matheus");
array.Add(true);

//Console.WriteLine(array[1]);
//array.Clear();

foreach(var item in array)
{
    Console.WriteLine(item);
}
*/

/*
========ARRAY TIPADO=============
//var arrayNum = new int[3] {1, 2, 3};
var arrayNum = new int[3];

arrayNum[0] = 5;
arrayNum[1] = 15;
arrayNum[2] = 10;

Array.Resize(ref arrayNum, 5);

foreach(var item in arrayNum)
{
    Console.WriteLine(item);
}
*/

/*
=======LISTA GENERICA============
var lista = new List<string>(10)
{
    "Matheus",
    "Muruci"
};

lista.Add("UVV");

//var nome = lista[2];

//Console.WriteLine(nome);

foreach(var item in lista)
{
    Console.WriteLine(item);
}
*/

/*
==========DICIONARIO===========
var dicionario = new Dictionary<int, string>()
{
    {3, "Teste"}
};
dicionario.Add(1, "Matheus");
dicionario[2] = "Muruci";

var nome = dicionario[2];

//Console.WriteLine(nome);

foreach(var item in dicionario)
{
    Console.WriteLine(item.Value);
    //Console.WriteLine(item.Key);
}
*/

/*
=========FILA=============

var fila = new Queue<string>();

fila.Enqueue("Matheus");
fila.Enqueue("Muruci");

//Peek() pega o 1° nome da fila, First in first out
/*var nome = fila.Peek();
var nome1 = fila.Peek();
Console.WriteLine(nome);
Console.WriteLine(nome1);

var nome = fila.Dequeue();
var nome1 = fila.Dequeue();
Console.WriteLine(nome);
Console.WriteLine(nome1);

/*foreach(var item in fila)
{
    Console.WriteLine(item);
}
*/

/*
=========PILHA=============
var pilha = new Stack<string>();

pilha.Push("Matheus");
pilha.Push("Muruci");

var nome = pilha.Pop();
var nome1 = pilha.Pop();

Console.WriteLine(nome);
Console.WriteLine(nome1);

/*foreach(var item in pilha)
{
    Console.WriteLine(item);
}
*/

// ==============ESTRUTURA DE CONTROLE===========

/*
===============IF/ELSE IF/ ELSE==============

var diaDaSemana = 1;
var diaDeTrabalho = true;

if(diaDaSemana == 0 && !diaDeTrabalho)
{
    Console.WriteLine("Domingo");
}
else if(diaDaSemana == 0 && diaDeTrabalho)
{
    Console.WriteLine("Trabalhar no domingo");
}
else
{
    Console.WriteLine("Não é domingo");
}
*/

/*
==========SWITCH================

var diaDaSemana = 4;

switch(diaDaSemana)
{
    case 0:
        Console.WriteLine("Hoje é domingo");
        break;
    case 1:
        Console.WriteLine("Hoje é segunda");
        break;
    case 2:
        Console.WriteLine("Hoje é terca");
        break;
    case 3:
        Console.WriteLine("Hoje é quarta");
        break;
    case 4:
        Console.WriteLine("Hoje é quinta");
        break;
    case 5:
        Console.WriteLine("Hoje é sexta");
        break;
    case 6:
        Console.WriteLine("Hoje é sabado");
        break;
    default:
        Console.WriteLine("Dia da semana invalido");
        break;
}
*/

/*
=========FOR============

var lista = new List<string>() {"Matheus", "Muruci", "Curso"};

for (int i = 0; i < lista.Count; i++)
{
    var nome = lista[i];
    Console.WriteLine(nome);
}
*/

/*
=======FOREACH============

var lista = new List<string>() {"Matheus", "Muruci", "Curso"};

foreach (string item in lista)
{
    Console.WriteLine(item);
}

foreach(var letra in "Matheus Muruci")
    Console.WriteLine(letra);
*/

/*
===========WHILE/DO WHILE==============

int i = 0;
int j = 0;

while(i < 10)
{
    Console.WriteLine("var i = " + i);
    i++;
}

do
{
    Console.WriteLine("var j = " + j);
    j++;
} while(j < 10);
*/

/*
============BREAK/CONTINUE=============

int i = 0;

while(i < 5)
{
    if (i < 2)
    {
        Console.WriteLine("Continuando...");
        i++;
        continue;
    }

    Console.WriteLine("var i = " + i);
    i++;

    if (i == 2)
    {
        Console.WriteLine("Valor de i é 2");
        break;
    }
}
*/