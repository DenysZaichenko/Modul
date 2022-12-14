using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Sh3 : Dostup
    {
        public Sh3()
        {

        }
        public static int viborVk()
        {
            if (NomerchetSh3 != 3333)
            {
                initialize();
            }


        repeatTop:
            Console.Write($"\nЗдравствуйте {NameSh3}." +
                          $"\nНа вашем счету {MoneySh3} грн." +
                          $"\nНомер вашего счета — {NomerchetSh3}." +
                          $"\nВаш номер в базе — {NomerSh3}." +
                          $"\nВаш вклад — {VkladSh3}( 0 - вклада не сужествует; 1 - простой; 2 - на 6 месяцев 3 - анонимный; 4 - с премией. )" +
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
                        MoneySh3 += k1;
                        Console.Write($"\nТеперь на вашем счету {MoneySh3} грн.");
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

                    if (k2 <= MoneySh3)
                    {
                        MoneySh3 -= k2;

                        Console.Write($"\nТеперь на вашем счету {MoneySh3} грн.");
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
                            VkladSh3 = 1;
                            goto repeatTop;
                            break;
                        case 2:
                            VkladSh3 = 2;
                            Moneycheck3 = MoneySh3;
                            goto repeatTop;
                            break;
                        case 3:
                            VkladSh3 = 3;
                            goto repeatTop;
                            break;
                        case 4:
                            VkladSh3 = 4;
                            Moneycheck3 = MoneySh3;
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
            NameSh3 = "Demid";
            MoneySh3 = 20000;
            NomerSh3 = 3;
            NomerchetSh3 = 3333;
            VkladSh3 = 0;
            time3 = 0;
        }
        public static int calc()
        {


            switch (VkladSh3)
            {
                case 1:

                    MoneySh3 *= 1.06;
                    Console.Write($" Пользователь {NameSh3} Теперь на вашем счету {MoneySh3} грн.\n");
                    VkladSh3 = 0;
                    break;

                case 2:
                    time3++;
                    Console.Write("Время " + time3 + "\n");
                    if (MoneySh3 == Moneycheck3)
                    {
                        if (time3 == 6)
                        {
                            MoneySh3 *= 1.32;
                            Console.Write($" Пользователь {NameSh3} Теперь на вашем счету {MoneySh3} грн.\n");
                            VkladSh3 = 0;
                            time3 = 0;
                        }
                    }
                    else
                    {
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                            $" теперь время на 6-месячный счет обнулено\n");
                        time3 = 0;

                    }

                    break;

                case 3:

                    Random rnd = new Random();
                    double value = rnd.Next(2, 8);
                    Console.WriteLine("Рандомный %" + value + "\n");
                    value = 1 + (value / 100);
                    MoneySh3 += value;
                    Console.Write($" Пользователь {NomerSh3} Теперь на вашем счету {MoneySh3} грн.\n");
                    VkladSh3 = 0;
                    break;

                case 4:
                    time3++;
                    Console.Write("Время " + time3 + "\n");

                    if (MoneySh3 == Moneycheck3 && time3 == 4)
                    {
                        MoneySh3 *= 1.08;
                        Console.Write($" Пользователь {NameSh3} Вы получили премию. Теперь на вашем счету {MoneySh3} грн.\n");
                        time3 = 0;
                        VkladSh3 = 0;
                    }
                    else if (MoneySh3 != Moneycheck3)
                    {
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                           $" теперь время на 4-месячный счет обнулено\n");
                        time3 = 0;
                    }
                    else
                    {
                        MoneySh3 *= 1.05;
                        Console.Write($" Пользователь {NameSh3} Теперь на вашем счету {MoneySh3} грн.\n");
                        Moneycheck3 = MoneySh3;
                    }

                    break;
            }

            return 0;
        }
    }
}
