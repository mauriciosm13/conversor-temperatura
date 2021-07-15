using System;
using System.Threading;

namespace calculoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tempetura: Em Graus(º)"); //Variavel de temp
            float temperatura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a escala: C para Celsius, F para Fahrenheit");//Definindo a escala
            string escala = Console.ReadLine();
                        
            switch (escala) { //Switch para chamar cada função e caso tenha algum erro feche
                case "C":
                    float retorno = temperaturaCelsius(temperatura); //Chamando função
                    Console.WriteLine(Math.Round(retorno, 2));
                  break;
                case "F":
                    retorno = temperaturaFahrenheit(temperatura); //Chamando função
                    Console.WriteLine(Math.Round(retorno, 2));
                    break;
                default:
                    Console.WriteLine("Escala não encontrada");
                    Thread.Sleep(200); //Sleep para aparecer mensagem
                    Environment.Exit(0); //Fechando console
                    break;

            }

            Thread.Sleep(1000); //Sleep para aparecer mensagem
            Environment.Exit(0); //Fechando console
        }
        static float temperaturaCelsius(float temperatura) // Função para calcular a temperatura em Celsius
        {
            float celsius = (temperatura - 32)/ 1.8f;
            return celsius;
        }

        static float temperaturaFahrenheit(float temperatura)// Função para calcular a temperatura em Fahrenheit
        {
            float fahrenheit = temperatura * 1.8f + 32;
            return fahrenheit;
        }

    }
}
