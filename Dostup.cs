using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Dostup : Baze
    {
        public static int viborSh()
        {

        repeat1:
           
          
            
            Console.Write("Выберите действие:\n" +
                "1. Воспользоваться счетом." +
                "2. Пропуск месяца.");

            int v = Convert.ToInt32(Console.ReadLine());

            if (v == 1)
            {
                Console.Write("Выберите счет которым хотите воспользоваться:\n" +
                "1111\n" +
                "2222\n" +
                "3333\n" +
                "4444\n");

                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1111:
                        Sh1.viborVk();
                        break;
                    case 2222:
                        Sh2.viborVk();
                        break;
                    case 3333:
                        Sh3.viborVk();
                        break;
                    case 4444:
                        Sh4.viborVk();
                        break;
                }
            }
            else if (v == 2)
            {
                Sh1.calc();
                Sh2.calc();
                Sh3.calc();
                Sh4.calc();
                goto repeat1;
            }


            return 0;
        }
    }
}
