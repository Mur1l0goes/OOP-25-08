// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("en-GB");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartão de Débito --");

Cartao cartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);