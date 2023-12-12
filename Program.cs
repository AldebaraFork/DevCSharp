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

Console.WriteLine("Digite a nota do primeiro bimestre: ");
double PrimeiraNota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a segunda nota do bimestre: ");
double SegundaNota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a Terceira nota do Bimestre: ");



double NotasBimestre = PrimeiraNota + SegundaNota / 2;

if (NotasBimestre < 75.00)
{
    Console.WriteLine("Voce foi reprovado, Agende sua reaplicação da prova! ");

}
else 
{
    Console.WriteLine("Parabens! Voce foi aprovado(a) com nota " + NotasBimestre.ToString("F1",CultureInfo.InvariantCulture));
}
        