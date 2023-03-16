using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjParking.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicle = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour; 
        }

        public void AddVehicle() 
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string plate = Console.ReadLine();

            if (plate.Length == 7) 
            {
                vehicle.Add(plate);
                Console.WriteLine("Placa Adicionada!");
            }
            else 
            {
                Console.WriteLine("Placa Incorreta!");
            }
        }

        public void RemoveVehicle() 
        {
            Console.WriteLine("Digite a placa para remover: ");
            string plate = Console.ReadLine();

            if(vehicle.Any(x => x.ToUpper() == plate.ToUpper())) 
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal hours = 0;
                decimal amount = 0;
                hours = Convert.ToDecimal(Console.ReadLine());
                amount = (initialPrice) + pricePerHour * hours;

                vehicle.Remove(plate);

                Console.WriteLine($"O veículo {plate} foi removido e o valor total foi de: R$ {amount}");

            }
            else 
            {
                Console.WriteLine("Desculpe, esse veículo não consta no sistema - Confirme se digitou a placa corretamente");

            }
        }   

        public void ListVehicle() 
        {
            if (vehicle.Any(item => true)) 
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string item in vehicle) 
                {
                    Console.WriteLine(item);    
                }
            }
            else 
            {
                Console.WriteLine("Não há veículos estacionados");

            }
        }  
    }
}
