﻿using System;

namespace Revisao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];
            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];
            float[] media = new float [10];

            int aprovados = 0;
            int reprovados = 0;

            

            for (var i = 0; i < 10; i++)
            {
                Console.Write("Digite o nome do(a) aluno(a): ");
                nomes[i] = Console.ReadLine();
                
                Console.WriteLine("Digite as notas do aluno: ");
                nota1[i] = float.Parse(Console.ReadLine());
                nota2[i] = float.Parse(Console.ReadLine());
                nota3[i] = float.Parse(Console.ReadLine());
                nota4[i] = float.Parse(Console.ReadLine());
                
            }

            float calc(float nota1, float nota2, float nota3, float nota4){

                float resultado = (nota1 + nota2 + nota3 + nota4) / 4;
                return resultado;
            }

            for (var i = 0; i < 10; i++)
            {
                
                media[i] = calc(nota1[i],nota2[i],nota3[i],nota4[i]);
                Console.WriteLine($"A média do(a) aluno(a) {nomes[i]} foi: {media[i]}");

                if(media[i] >=7){
                aprovados++;
                }
                if (media[i] < 7){
                reprovados++;
                }
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Número de aprovados: {aprovados}");
            Console.WriteLine($"Número de reprovados: {reprovados}");
            Console.WriteLine("--------------------------------------");
            

            
        }
    }
}
