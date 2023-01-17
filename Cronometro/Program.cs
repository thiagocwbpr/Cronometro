

using System.ComponentModel.Design;
using System.Reflection;

Menu();
static void Menu() {

    Console.Clear();

    Console.WriteLine("\nCRONOMETRO DIGITAL!\n");
    Console.Write("\n\nInforme o tempo que deseja cronometrar: ");
    int timeMenu = int.Parse(Console.ReadLine());

    inicio(timeMenu);
}
static void inicio(int time) {

	while (time != 0) {

        Console.Clear();
        time--;
        Console.WriteLine($"\n\n\t{time}\n\n");
        Thread.Sleep(1000);
        if (time == 0) {
            Console.Clear();
            Console.WriteLine("\n\n\tBAIXE A CABEÇA E VAI ESTUDAR!!!\n\n\n");
            Console.WriteLine("\n\nO CRONOMETRO ZEROU! CLIQUE EM QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL.");
            Console.ReadKey();
            Menu();
        }
    }
}