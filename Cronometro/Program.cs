

using System.ComponentModel.Design;
using System.Reflection;

Menu();
static void Menu() {

    Console.Clear();

    Console.WriteLine("\nCRONOMETRO DIGITAL!\n");
    Console.Write("\nS = Segundo => 10s = 10 segundos ");
    Console.Write("\nM = Minuto => 1m = 1 minuto");
    Console.Write("\n00 = Sair\n");
    Console.Write("\nQuanto tempo deseja contar?  ");
    string data = Console.ReadLine().ToLower();

    int time = int.Parse(data.Substring(0, data.Length - 1));
    char type = char.Parse(data.Substring(data.Length - 1, 1));

    int multiplier = 1;
    int typeCronometro = 0;

    
    if (type == 'm') {
        multiplier = 60;
        Console.WriteLine("\nDeseja usar o cronometro de forma Crescente ou Decrescente? ");
        Console.WriteLine("1 - Crescente");
        Console.WriteLine("2 - Decrescente");
        Console.Write("\nDigite a opção numerica informada acima : ");
        typeCronometro = int.Parse(Console.ReadLine());
    }
    if (time == 0) {
        System.Environment.Exit(0);
    }

    inicio(multiplier * time, typeCronometro);
    }
static void inicio(int time, int typeCrono) {

    if (typeCrono == 1) {
        int typeCrono2 = 0;
        Console.Clear();
        Console.WriteLine("\nReady...\n");
        Thread.Sleep(1000);
        Console.WriteLine("\nSet...\n");
        Thread.Sleep(1000);
        Console.WriteLine("\nGo...\n");
        Thread.Sleep(2500);
        while (time != typeCrono2) {
            Console.Clear();
            typeCrono2++;
            Console.WriteLine($"\n\n\t{typeCrono2}\n\n");
            Thread.Sleep(1000);
        }
        Console.WriteLine("TIME IS UP! PRESS ANY KEY!");
        Console.ReadKey();
        Menu();
    }
    else {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2500);
        while (time != 0) {
            Console.Clear();
            time--;
            Console.WriteLine($"\n\n\t{time}\n\n");
            Thread.Sleep(1000);
        }
        Console.WriteLine("TIME IS UP! PRESS ANY KEY!");
        Console.ReadKey();
        Menu();
    }
}