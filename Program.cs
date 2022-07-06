using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_djalma_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidade = "";
            Console.WriteLine("informe o codigo da cidade desejada: \n 1-atibaia  \n 2-Bragança Paulista \n 3-Mairiporã \n 4-Nazaré \n 5-Extrema\n 6-Extrema \n 7-Vargem ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            switch (codigo)
            {
                case 1:
                    cidade = "Atibaia";
                    break;
                case 2:
                    cidade = "Bragança paulista ";
                    break;
                case 3:
                    cidade = "Mairiporã";
                    break;
                case 4:
                    cidade = "Nazaré";
                    break;
                case 5:
                    cidade = "Terra Preta";
                    break;
                case 6:
                    cidade = "Extrema";
                    break;
                case 7:
                    cidade = "Vargem";
                    break;



            }

            Console.WriteLine("digite uma data dd/mm/aaaa");
            var d = Convert.ToDateTime(Console.ReadLine());
            int dia, mes, ano;
            dia = d.Day;
            mes = d.Month;
            ano = d.Year;
            string mes3 = Dataextenso(mes);
            Console.WriteLine($"{cidade},{dia} de {mes} de {ano}");
            Console.ReadKey();





        }
        static public string Dataextenso(int mes)
        {
            string mesextenso = null;
            switch (mes)
            {
                case 1:
                    mesextenso = "janeiro";
                    break;
                case 2:
                    mesextenso = "fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;




            }
            string mes2 = mesextenso;
            return mes2;
        }
    }
}
