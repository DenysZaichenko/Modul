using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul21
{
    internal class Sh1: Dostup
    {
        public int viborVk()
        {
            Name = "Denis";
            Money = 10000;
            Nomer = 1;
            Nomerchet = 1111;
            Vklad = 0;

            repeatTop:
            Console.Write($"\nЗдравствуйте {Name}." +
                          $"\nНа вашем счету {Money} грн." +
                          $"\nНомер вашего счета — {Nomerchet}." +
                          $"\nВаш номер в базе — {Nomer}." +
                          $"\nВаш вклад — {Vklad}( 0 - вклада не сужествует; 1 - простой; 2 - на 6 месяцев 3 - анонимный; 4 - с премией. )" +
                          $"\n\nВыберите действие которым хотите воспользоваться:\n" +
                " 1.Доложить деньги\n" +
                " 2.Снять деньги\n" +
                " 3.Вклад\n" +
                " 4.Выход из счета\n");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                repeat1:
                    Console.Write("\nВведите сумму которую хотите добавить:");
                    float k1 = Convert.ToInt32(Console.ReadLine());

                    if (k1 >= 0)
                    {
                        Money = Money + k1;
                        Console.Write($"\nТеперь на вашем счету {Money} грн.");
                    }
                    else
                    {
                        Console.Write($"Введите правильное число.");
                        goto repeat1;
                    }

                    goto repeatTop;
                    break;
                case 2:
                repeat2:
                    Console.Write("\nВведите сумму которую хотите снять:");
                    float k2 = Convert.ToInt32(Console.ReadLine());

                    if (k2 <= Money)
                    {
                        Money = Money - k2;

                        Console.Write($"\nТеперь на вашем счету {Money} грн.");
                    }
                    else
                    {
                        Console.Write($"Введите правильное число.");
                        goto repeat2;
                    }

                    goto repeatTop;
                    break;
                case 3:
                repeat3:
                    Console.Write("\nВыберите вид вклада которым хотите воспользоваться:\n" +
                            " 1.Простой\n" +
                            " 2.На 6 месяцев\n" +
                            " 3.Анонимный\n" +
                            " 4.С премией\n");

                    int t = Convert.ToInt32(Console.ReadLine());

                    switch (t)
                    {
                        case 1:
                            Vklad = 1;
                            goto repeatTop;
                            break;
                        case 2:
                            Vklad = 2;
                            goto repeatTop;
                            break;
                        case 3:
                            Vklad = 3;
                            goto repeatTop;
                            break;
                        case 4:
                            Vklad = 4;
                            goto repeatTop;
                            break;
                        default:
                            Console.Write($"Введите правильное число.");
                            goto repeat3;
                    }
                    break;
                case 4:
                    Dostup dost = new Dostup();
                    dost.viborSh();
                    break;
                default:
                    Console.Write($"Введите правильное число.\n");
                    goto repeatTop;
            }
       
            return 0;
        }

        public int calc()
        {
            Console.Write($"\nТеперь на вашем счету {Money} грн.");
            switch (Vklad) 
            {
                case 1:
                    Console.Write($"\nТеперь на вашем счету {Money} грн.");
                    break;
            }


            return 0;
        }
    }
}
