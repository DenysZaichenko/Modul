using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Sh1 : Dostup
    {
        public Sh1()
        {

        }
        public static int viborVk()
        {
            if (NomerchetSh1 != 1111)
            {
                initialize();
            }

            
        repeatTop:
            Console.Write($"\nЗдравствуйте {NameSh1}." +
                          $"\nНа вашем счету {MoneySh1} грн." +
                          $"\nНомер вашего счета — {NomerchetSh1}." +
                          $"\nВаш номер в базе — {NomerSh1}." +
                          $"\nВаш вклад — {VkladSh1}( 0 - вклада не сужествует; 1 - простой; 2 - на 6 месяцев 3 - анонимный; 4 - с премией. )" +
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
                        MoneySh1 += k1;
                        Console.Write($"\nТеперь на вашем счету {MoneySh1} грн.");
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

                    if (k2 <= MoneySh1)
                    {
                        MoneySh1 -= k2;

                        Console.Write($"\nТеперь на вашем счету {MoneySh1} грн.");
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
                            VkladSh1 = 1;
                            goto repeatTop;
                            break;
                        case 2:
                            VkladSh1 = 2;
                            Moneycheck1 = MoneySh1;
                            goto repeatTop;
                            break;
                        case 3:
                            VkladSh1 = 3;
                            goto repeatTop;
                            break;
                        case 4:
                            VkladSh1 = 4;
                            Moneycheck1 = MoneySh1;
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
            NameSh1 = "Denis";
            MoneySh1 = 10000;
            NomerSh1 = 1;
            NomerchetSh1 = 1111;
            VkladSh1 = 0;
            time1 = 0;
        }
        public static int calc()
        {
                switch (VkladSh1)
                {
                    case 1:

                        MoneySh1 *= 1.06;
                        Console.Write($" Пользователь {NameSh1} Теперь на вашем счету {MoneySh1} грн.\n");
                    VkladSh1 = 0;
                        break;

                    case 2:
                    time1 ++;
                    Console.Write("Время " + time1 + "\n");
                    if (MoneySh1 == Moneycheck1) {
                        if (time1 == 6)
                        {
                            MoneySh1 *= 1.32;
                            Console.Write($" Пользователь {NameSh1} Теперь на вашем счету {MoneySh1} грн.\n");
                            VkladSh1 = 0;
                            time1 = 0;
                        }
                    }
                    else
                    {
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                            $" теперь время на 6-месячный счет обнулено\n");
                        time1 = 0;
                       
                    }
                    break;

                    case 3:
                   
                    Random rnd = new Random();
                    double value = rnd.Next(2, 8);
                    Console.WriteLine("Рандомный %"+value+"\n");
                    value = 1+(value / 100);
                    MoneySh1 += value;
                    Console.Write($" Пользователь {NomerSh1} Теперь на вашем счету {MoneySh1} грн.\n");
                    VkladSh1 = 0;
                    break;

                    case 4:
                    time1++;
                    Console.Write("Время " + time1 + "\n");
                    
                    if (MoneySh1 == Moneycheck1 && time1 == 4)
                    {
                        MoneySh1 *= 1.08;
                        Console.Write($" Пользователь {NameSh1} Вы получили премию. Теперь на вашем счету {MoneySh1} грн.\n");
                        time1 = 0;
                        VkladSh1 = 0;
                    }
                    else if(MoneySh1 != Moneycheck1){
                        Console.Write($"\n Вы сняли или добавили деньги на счет " +
                           $" теперь время на 4-месячный счет обнулено\n");
                        time1 = 0;
                    }
                    else
                    {
                        MoneySh1 *= 1.05;
                        Console.Write($" Пользователь {NameSh1} Теперь на вашем счету {MoneySh1} грн.\n");
                        Moneycheck1 = MoneySh1;
                    }
                   
                    break;
                }
            
            return 0;
        }
    }
}
