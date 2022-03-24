using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Calendario
{
    public class Calendario
    {
        public Byte Mes { get; set; }
        public UInt16 Ano { get; set; }





        // Verifica se o mes e valido
        public Boolean isMesValido()
        {
            if (Mes < 13 && Mes > 0)
            {

                return true;
            }
            else
            {

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("O Mes deve seguir o formato numérico,\ntal como '3' para Março,\nportanto deve ser de 1 a 12.");
                    Console.WriteLine("--------------------------------");

                    return false;
                   
                }
            }


            // Verifica se o ano e valido 
            public Boolean isAnoValido()
            {
                if (Ano > 0 && Ano < 10000)
                {

                    return true;
                }
                else
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("O Ano deve seguir o formato numérico,\ntal como '2022',\nportanto deve ser de 1 a 9999.");
                    Console.WriteLine("--------------------------------");
                    //Console.WriteLine("\n");
                    return false;

                }



            }

            public string gerarCalendario() {

                // Obter o primeiro dia do mês atual
                var mes = new DateTime((int)Ano, Mes, 1);

                // Imprima o mês, o ano e os dias da semana   
                // cabecalho é calculado para alinhar o ano ao lado direito            
                var cabecalho = new string(' ', 12 - mes.ToString("MMMM").Length);
                Console.WriteLine($"{mes.ToString("MMMM")}{cabecalho}{mes.Year}");
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(" D  S  T  Q  Q  S  S ");
                Console.WriteLine(new string('-', 20));

            //Obtenha o número de dias que precisamos deixar em branco no 
            // início da semana 
            var diaesquerda = (int)mes.DayOfWeek;
                var diaatual = mes;

              


                // Imprima a parte do dia de cada dia do mês 
                // iteração é o número de vezes que fazemos um loop, que é o número
                // de dias no mês mais o número de dias que preenchemos no início
                var interacao = DateTime.DaysInMonth(mes.Year, mes.Month) + diaesquerda;
                for (int i = 0; i < interacao; i++)
                {
                    // Preenche a primeira semana com espaços vazios, se necessário.
                    if (i < diaesquerda)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        //Escreve o dia - e adiciona espaço entre os dias.
                        Console.Write($"{diaatual.Day.ToString().PadLeft(2, ' ')} ");

                        // Quando chegamos no final de uma semana, começa uma nova linha
                        if ((i + 1) % 7 == 0)
                        {
                            Console.WriteLine();
                        }

                        // adiciona nosso 'diaatual' para o dia seguinte
                        diaatual = diaatual.AddDays(1);

                    }

                }
                return "\n";
            }
        


    }
}

