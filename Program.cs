﻿// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Schema;

double conta;
int TempoBasico;
double juros;


TempoBasico = int.Parse(Console.ReadLine());

conta = 50.0;

if (TempoBasico > 100)
{
    juros = conta + (TempoBasico - 100) * 2;
    Console.WriteLine("Valor a pagar: " + juros);
}
else if (TempoBasico < 100)
    Console.WriteLine("Valor a pagar: " + conta);
