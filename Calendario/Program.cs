using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string tm;
            string ta;

            Calendario c1 = new Calendario();

            do
            {
                try
                {
                    Console.Write("Digite o mes desejado: ");
                    tm = Console.ReadLine();

                    //Convertendo string para byte e adicionando no atributo do objeto
                    c1.Mes = Byte.Parse(tm);
                }
                catch (Exception)
                {
                }

            } while (c1.isMesValido() == false);


            //repetição enquanto o ano for invalido
            do
            {
                try
               {

                    Console.Write("\nDigite o ano desejado: ");
                    ta = Console.ReadLine();

                    //Convertendo string para byte e adicionando no atributo do objeto
                    c1.Ano = UInt16.Parse(ta);
                } catch (Exception)
                {

                }


            } while (c1.isAnoValido() == false);

            Console.WriteLine($"\n{c1.gerarCalendario()}");
            

            
         } 
    }
}
