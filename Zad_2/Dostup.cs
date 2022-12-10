using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_2
{
    internal class Dostup : Base
    {
        public int viborSh()
        {
        repeat1:
            
            Console.Write("Время "+time+"\n");
       
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
                Sh1 sh1 = new Sh1();
                switch (n)
                {
                    case 1111:
                        
                        sh1.viborVk();
                        break;
                    case 2222:
                        Sh2 sh2 = new Sh2();
                        sh2.viborVk();
                        break;
                    case 3333:
                        Sh3 sh3 = new Sh3();
                        sh3.viborVk();
                        break;
                    case 4444:
                        Sh4 sh4 = new Sh4();
                        sh4.viborVk();
                        break;
                }
            }
            else if (v == 2)
            {
                time = time + 1;
                goto repeat1;
            }


            return 0;
        }
    }
}
