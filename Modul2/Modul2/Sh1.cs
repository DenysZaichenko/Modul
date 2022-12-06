using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Sh1:Dostup
    {
        public override float Nomer(int i)
        {
            i = 1;
            return 0;
        }
        public override float Name(string i)
        {
            i = "Денис";
            return 0;
        }
        public override float Nomerchet(int i)
        {
            i = 0001;
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
            Console.Write($"\nЗдравствуйте {Name}." +
                          $"\nНа вашем счету {Money}грн." +
                          $"\nНомер вашего счета — {Nomerchet}." +
                          $"\nВаш номер в базе — {Nomer}." +
                          $"\n\nВыберите действие которым хотите воспользоваться:\n" +
                " 1.Доложить деньги\n" +
                " 2.Снять деньги\n" +
                " 3.Вклад\n");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Write("Введите сумму которую хотите добавить:");
                    float k = Convert.ToInt32(Console.ReadLine());
                    
                    break;
                case 2:
                    Console.Write("Введите сумму которую хотите снять:");
                    break;
                case 3:
                    Console.Write("\nВыберите вид вклада которым хотите воспользоваться:\n" +
                            " 1.Простой\n" +
                            " 2.На 6 месяцев\n" +
                            " 3.Анонимный\n" +
                            " 4.С премией\n");

                    int t = Convert.ToInt32(Console.ReadLine());

                    switch (t)
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
                    break;
            }

            return 0;
        }
    }
}
