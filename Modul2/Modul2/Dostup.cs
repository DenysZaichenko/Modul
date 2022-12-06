using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Dostup:Base
    {
        public int viborSh()
        {
            Console.Write("Выберите счет которым хотите воспользоваться:\n" +
                "0001\n" +
                "0002\n" +
                "0003\n" +
                "0004\n");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 0001:
                    Sh1 sh1 = new Sh1();
                    sh1.viborVk();
                    break;
                case 0002:
                    Sh2 sh2 = new Sh2();
                    sh2.viborVk();
                    break;
                case 0003:
                    Sh3 sh3 = new Sh3();
                    sh3.viborVk();
                    break;
                case 0004:
                    Sh4 sh4 = new Sh4();
                    sh4.viborVk();
                    break;
            }
            return 0;
        }

        public override float Nomer(int i)
        {
        
            return 0;
        }
        public override float Name(string i)
        {
            return 0;
        }
        public override float Nomerchet(int i)
        {
            return 0;
        }
        public override float Money(float i) 
        {
            return 0;
        }
        public override float Vklad(int i)
        {
            return 0;
        }
    }
}
