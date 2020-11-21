using System;

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
            
                while(!float.TryParse(Console.ReadLine(), out nota1[i]));
                while(!float.TryParse(Console.ReadLine(), out nota2[i]));
                while(!float.TryParse(Console.ReadLine(), out nota3[i]));
                while(!float.TryParse(Console.ReadLine(), out nota4[i]));
               

                Console.WriteLine("--------------------------------------");
                
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

            float mediaDaSala = (media[0] + media[1] + media[2] + media[3] + media[4] + media[5] + media[6] + media[7] + media[8] + media[9]) / 10; 

            Console.WriteLine($"A média da sala foi de {mediaDaSala}");
            Console.WriteLine("--------------------------------------");

            
        }
    }
}
