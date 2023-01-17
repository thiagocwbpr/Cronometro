

using System.ComponentModel.Design;
using System.Reflection;

Menu();
static void Menu() {

    Console.Clear();

    Console.WriteLine("\nCRONOMETRO DIGITAL!\n");
    Console.Write("\n\nInforme o tempo que deseja cronometrar: ");
    int timeMenu = int.Parse(Console.ReadLine());
    Console.WriteLine("\nVocê deseja cronometrar de qual forma ?");
    Console.WriteLine("1 - Crescente");
    Console.WriteLine("2 - decrescente");
    Console.Write("\nEscolha uma das opções numeros acima: ");
    int tipoCrono = int.Parse(Console.ReadLine());
    

    inicio(timeMenu, tipoCrono);
}
static void inicio(int time, int tipoCronmetro) {

    if (tipoCronmetro == 1) {

        int time2 = 0;

        while (time2 <= time) {

            Console.Clear();
            time2++;
            Console.WriteLine($"\n\n\t{time2}\n\n");
            Thread.Sleep(1000);
            if (time2 == 20) {
                Console.Clear();
                Console.WriteLine("\n\n\tTIME IS UP!!!\n\n\n");
                Console.WriteLine("\n\nO CRONOMETRO ZEROU! CLIQUE EM QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL.");
                Console.ReadKey();
                Menu();
            }
        }

    }
    else {
        while (time != 0) {

            Console.Clear();
            time--;
            Console.WriteLine($"\n\n\t{time}\n\n");
            Thread.Sleep(1000);
            if (time == 0) {
                Console.Clear();
                Console.WriteLine("\n\n\tTIME IS UP!!!\n\n\n");
                Console.WriteLine("\n\nO CRONOMETRO ZEROU! CLIQUE EM QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL.");
                Console.ReadKey();
                Menu();
            }
        }
    }
}