﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_2
{
    internal class Sh2 : Dostup
    {
        public int viborVk()
        {
            NameSh2 = "Denis";
            MoneySh2 = 10000;
            NomerSh2 = 1;
            NomerchetSh2 = 1111;
            VkladSh2 = 0;

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
                        MoneySh2 = MoneySh2 + k1;
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
                        MoneySh2 = MoneySh2 - k2;

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
                            goto repeatTop;
                            break;
                        case 3:
                            VkladSh2 = 3;
                            goto repeatTop;
                            break;
                        case 4:
                            VkladSh2 = 4;
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
            Console.Write($"\nТеперь на вашем счету {MoneySh2} грн.");
            switch (VkladSh2)
            {
                case 1:
                    Console.Write($"\nТеперь на вашем счету {MoneySh2} грн.");
                    break;
            }


            return 0;
        }
    }
}
