using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Pag82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random GeracaoAleatoriaDeMedalhas = new Random();

            int[,] ResultadoJogosPanamericanos = new int[5, 3];
            int[] TotalDeMedalhasPorPais = new int[5];
            int[] TotalMedalhasDePrata = new int[5];
            int[] TotalMedalhasDeOuro = new int[5];
            int MenorQuantidadeDeMedalhasDePrata = int.MaxValue;
            int MaiorQuantidadeDeMedalhasDeOuro = int.MinValue;
            string PaisVencedorDosJogos = "";
            string PaisMenorNumeroMedalhasDePrata = "";
            string[] PaisesParticipantes = { "Brasil", "EUA", "Colombia", "Canadá", "Mexico" };
            string texto = "Tabela do resultado dos jogos:  \n"; 

            for(int pais = 0; pais < ResultadoJogosPanamericanos.GetLength(0); pais++) 
            { 
                for(int medalhas = 0; medalhas < ResultadoJogosPanamericanos.GetLength(1); medalhas++)
                {
                    ResultadoJogosPanamericanos[pais, medalhas] = GeracaoAleatoriaDeMedalhas.Next(0, 31);
                    texto += ResultadoJogosPanamericanos[pais, medalhas] + "\t";
                    TotalDeMedalhasPorPais[pais] += ResultadoJogosPanamericanos[pais, medalhas];
                }
                texto += "\n";
            }

            for (int pais = 0; pais < ResultadoJogosPanamericanos.GetLength(0); pais++)
            {
                TotalMedalhasDeOuro[pais] = ResultadoJogosPanamericanos[pais, 0];
                TotalMedalhasDePrata[pais] = ResultadoJogosPanamericanos[pais, 1];
                if (TotalMedalhasDePrata[pais] < MenorQuantidadeDeMedalhasDePrata)
                {
                    PaisMenorNumeroMedalhasDePrata = PaisesParticipantes[pais];
                    MenorQuantidadeDeMedalhasDePrata = TotalMedalhasDePrata[pais];
                }
                if(TotalMedalhasDeOuro[pais] > MaiorQuantidadeDeMedalhasDeOuro)
                {
                    PaisVencedorDosJogos = PaisesParticipantes[pais];
                    MaiorQuantidadeDeMedalhasDeOuro = TotalMedalhasDeOuro[pais];
                }    
            }

            Console.WriteLine("O país vencedor dos jogos foi o(a): " + PaisVencedorDosJogos + " com " + MaiorQuantidadeDeMedalhasDeOuro + " medalhas de ouro");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("O país com menor número de medalhas de prata foi o(a): " + PaisMenorNumeroMedalhasDePrata + " com " + MenorQuantidadeDeMedalhasDePrata);
            Console.WriteLine("-------------------------------------------------");

            for (int paises = 0; paises < TotalDeMedalhasPorPais.Length; paises++)
            {
                Console.WriteLine("O total de medalhas do(a) " + PaisesParticipantes[paises] + " foi de: " + TotalDeMedalhasPorPais[paises]);  
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(texto);
            Console.ReadKey();
        }
        
    }
}
