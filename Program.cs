﻿using System;

namespace Aula5CSharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            float altura;
            float peso;
            int idade; 
            float imc;

            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

    

            if(imc < 18.5)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Abaixo peso");
            }
            else if(imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if(imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }

            Console.WriteLine(nome + " " + idade + " anos, " + altura + "metro, " + peso + "Kg.");

            


        }
    }
}
