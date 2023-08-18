using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("===================");

            Console.Write("Digite seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            Console.WriteLine("Classificação:");
            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc < 25)
                Console.WriteLine("Peso normal");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso");
            else
                Console.WriteLine("Obesidade");

            Console.ReadLine();
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}
