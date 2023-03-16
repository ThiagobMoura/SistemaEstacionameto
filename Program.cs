using ProjParking.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja Bem vindo ao ALPARKING!\n" +
                    "Digite o preço inicial:");

initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking es = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showLess = true;

while (showLess)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine()) 
    {
        case "1":
            es.AddVehicle();
            break;

        case "2":
            es.RemoveVehicle();
            break;

        case "3":
            es.ListVehicle();
            break;

        case "4":
            showLess = false;
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O Programa se encerrou!");
