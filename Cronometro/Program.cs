﻿

using System.ComponentModel.Design;
using System.Reflection;

Menu();
static void Menu() {

    Console.Clear();

    Console.WriteLine("\nCRONOMETRO DIGITAL!\n");
    Console.Write("\nS = Segundo => 10s = 10 segundos ");
    Console.Write("\nM = Minuto => 1m = 1 minuto");
    Console.Write("\n0 = Sair\n");
    Console.Write("\nQuanto tempo deseja contar?  ");
    string data = Console.ReadLine().ToLower();
    Console.WriteLine("\nDeseja usar o cronometro de forma Crescente ou Decrescente? ");
    Console.WriteLine("1 - Crescente");
    Console.WriteLine("2 - Decrescente");
    Console.Write("\nDigite a opção numerica informada acima : ");
    int typeCronometro = int.Parse(Console.ReadLine());


    int time = int.Parse(data.Substring(0, data.Length - 1));
    char type = char.Parse(data.Substring(data.Length - 1, 1));
   

    