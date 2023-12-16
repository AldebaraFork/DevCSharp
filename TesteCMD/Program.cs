// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Schema;


Console.WriteLine("Ola! Escreva um numero de 1 a 7 ");

int NumeroInserido = int.Parse(Console.ReadLine());


if (NumeroInserido == 1) {
    Console.WriteLine("Hoje é segunda feira ");
}else if (NumeroInserido == 2)
{
    Console.WriteLine("Hoje é terça-feira ");
}else if (NumeroInserido == 3)
{
    Console.WriteLine("Hoje é quarta-feira ");
}else if(NumeroInserido == 4)
{
    Console.WriteLine("Hoje é quiunta-feira ");

}else if (NumeroInserido == 5)
{
    Console.WriteLine("Hoje é sexta-feira ");
}else if (NumeroInserido == 6)
{
    Console.WriteLine("Hoje é Sabado! ");
}else if (NumeroInserido == 7)
{
    Console.WriteLine("Hoje é domingo! ");
}else
{
    Console.WriteLine("Numero incorreto inserido, Por-favor insira um numero de 1 a 7");
}
