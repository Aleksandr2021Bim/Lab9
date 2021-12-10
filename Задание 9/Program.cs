using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую инженер \nя калькулятр введите данные");
            float a, b;
            int n = 0;
            try
            {
                Console.WriteLine("Введите целое число a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число b=");
                b = Convert.ToInt32(Console.ReadLine()); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка" + ex.Message);
                throw;
            }
            
            Console.WriteLine("Введите код операции \n1 - сложение\n2 - вычитание\n3 - произведение\n4 - частное");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if (n == 1)
                {
                    Console.WriteLine(a + b);
                    break;
                }
                else
                {
                    if (n == 2)
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                    else
                    {
                        if (n == 3)
                        {
                            Console.WriteLine(a * b);
                            break;
                        }
                        else
                        {
                            if (n == 4)
                            {
                                try
                                {
                                    Console.WriteLine(a % b);
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.WriteLine("Ошибка деления на !0");
                                    throw;
                                }
                            }
                            else
                            if (n > 4)
                            {
                                Console.WriteLine("Ошибка ввода");
                            }
                          
                        }
                    }

                }

            }
            Console.WriteLine("Результат ={0}", n);
            Console.ReadKey();

        }   
    }
}
