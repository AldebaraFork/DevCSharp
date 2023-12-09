// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Schema;


Console.WriteLine("Ola bem vindo! Por favor Insira seu nome: ");
string[] dados = Console.ReadLine().Split(' ');

string nome = dados[0];
Console.WriteLine("Otimo! Seja bem vindo(a) " + nome + " Porfavor insira sua idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade >= 18)
{
    Console.WriteLine("Seja bem Vindo! Pode utilizar nossa plataforma a vontade! ");
}
else
{
    Console.WriteLine("Opa! parece que voce é de menor, voce possui apenas " + idade);
}

