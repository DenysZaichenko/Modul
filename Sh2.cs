using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Sh2 : Dostup
    {
        public Sh2()
        {

        }
        public static int viborVk()
        {
            if (NomerchetSh2 != 2222)
            {
                initialize();
            }


        repeatTop:
            Console.Write($"\nЗдравствуйте {NameSh2}." +
                          $"\nНа вашем счету {MoneySh2} грн." +
                          $"\nНомер вашего счета — {NomerchetSh2}." +
                          $"\nВаш номер в базе — {NomerSh2}." +
                          $"\nВаш вклад — {VkladSh2}( 0 - вклада не сужествует; 1 - простой; 2 - на 6 месяцев 3 - анонимный; 4 - с премией. )" +
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
                        MoneySh2 += k1;
                        Console.Write($"\nТеперь на вашем счету {MoneySh2} грн.");
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

                    if (k2 <= MoneySh2)
                    {
                        MoneySh2 -= k2;

                        Console.Write($"\nТеперь на вашем счету {MoneySh2} грн.");
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
                            VkladSh2 = 1;
                            goto repeatTop;
                            break;
                        case 2:
                            VkladSh2 = 2;
                            Moneycheck2 = MoneySh2;
                            goto repeatTop;
                            break;
                        case 3:
                            VkladSh2 = 3;
                            goto repeatTop;
                            break;
                        case 4:
                            VkladSh2 = 4;
                            Moneycheck2 = MoneySh2;
                            goto repeatTop;
                            break;
                        default:
                            Console.Write($"Введите правильное число.");
                            goto repeat3;
                    }
                    break;
                case 4:
                    viborSh();
                    break;
                default:
                    Console.Write($"Введите правильное число.\n");
                    goto repeatTop;
            }

            return 0;
        }

        private static void initialize()
        {
            NameSh2 = "Valik";
            MoneySh2 = 15000;
            NomerSh2 = 2;
            NomerchetSh2 = 2222;
            VkladSh2 = 0;
            time2 = 0;
        }
        public static int calc()
        {


            switch (VkladSh2)
            {
                case 1:

                    MoneySh2 *= 1.06;
                    Console.Write($" Пользователь {NameSh2} Теперь на вашем счету {MoneySh2} грн.\n");
                    VkladSh2 = 0;
                    break;

                case 2:
                    time2++;
                    Console.Write("Время " + time2 + "\n");
                    if (MoneySh2 == Moneycheck2)
                    {
                        if (time2 == 6)
                        {
                            MoneySh2 *= 1.32;
                            Console.Write($" Пользователь {NameSh2} Теперь на вашем счету {MoneySh2} грн.\n");
                            VkladSh2 = 0;
                            time2 = 0;
                        }
                    }
                    else
                    {
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                            $" теперь время на 6-месячный счет обнулено\n");
                        time2 = 0;

                    }

                    break;

                case 3:

                    Random rnd = new Random();
                    double value = rnd.Next(2, 8);
                    Console.WriteLine("Рандомный %" + value + "\n");
                    value = 1 + (value / 100);
                    MoneySh2 += value;
                    Console.Write($" Пользователь {NomerSh2} Теперь на вашем счету {MoneySh2} грн.\n");
                    VkladSh2 = 0;
                    break;

                case 4:
                    time2++;
                    Console.Write("Время " + time2 + "\n");

                    if (MoneySh2 == Moneycheck2 && time2 == 4)
                    {
                        MoneySh2 *= 1.08;
                        Console.Write($" Пользователь {NameSh2} Вы получили премию. Теперь на вашем счету {MoneySh2} грн.\n");
                        time2 = 0;
                        VkladSh2 = 0;
                    }
                    else if (MoneySh2 != Moneycheck2)
                    {
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                           $" теперь время на 4-месячный счет обнулено\n");
                        time2 = 0;
                    }
                    else
                    {
                        MoneySh2 *= 1.05;
                        Console.Write($" Пользователь {NameSh2} Теперь на вашем счету {MoneySh2} грн.\n");
                        Moneycheck2 = MoneySh2;
                    }

                    break;
            }

            return 0;
        }
    }
}
