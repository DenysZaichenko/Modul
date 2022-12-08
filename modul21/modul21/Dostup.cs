using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul21
{
    internal class Dostup:Base
    {
        public int viborSh()
        {
            Console.Write("Выберите действие:\n" +
                "1. Воспользоваться счетом." +
                "2. Пропуск месяца(вызов функции calc).");

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
                        Sh1 sh1 = new Sh1();
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
                Sh1 cal = new Sh1();
                cal.calc();
            }
            

            return 0;
        }
    }
}
