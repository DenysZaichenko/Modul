﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Sh4:Dostup
    {
        public override float Nomer(int i)
        {
            i = 4;
            return 0;
        }
        public override float Name(string i)
        {
            i = "Костя";
            return 0;
        }
        public override float Nomerchet(int i)
        {
            i = 0004;
            return 0;
        }
        public override float Money(float i)
        {
            i = 10000;
            return 0;
        }
        public override float Vklad(int i)
        {
            i = 0;
            return 0;
        }

        public int viborVk()
        {
            Console.Write("Здравствуйте Костя.Выберите вид вклада которым хотите воспользоваться:\n" +
                "1.Простой\n" +
                "2.На 6 месяцев\n" +
                "3.Анонимный\n" +
                "4.С премией\n");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Vklad(1);
                    break;
                case 2:
                    Vklad(2);
                    break;
                case 3:
                    Vklad(3);
                    break;
                case 4:
                    Vklad(4);
                    break;
            }
            return 0;
        }
    }
}
