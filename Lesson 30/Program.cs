using System;

namespace Lesson_30
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // Домашнее задание
                // Сделать проект с небезопасным кодом
                // Поработать с указателями (получить ссылку, передать ссылку, прочитать адрес, прочитать значение)
                // Создать указатель на указатель

                int i = 30;

                int* address = &i;

                Console.WriteLine(*address);
                Console.WriteLine((long)address);

                int a = 5;
                int b = 7;

                Console.WriteLine(*(&a + 4));

                Calc(a, &b);

                Console.WriteLine(a);
                Console.WriteLine(b);

                int* address2 = address + 4;
                *address2 = 777;
                Console.WriteLine(*address2);

                Console.WriteLine();


                int** adr = &address;
                Console.WriteLine((long)adr);
                Console.WriteLine((long)*adr);
                Console.WriteLine(**adr);

                Console.ReadLine();
            }
        }

        static unsafe void Calc(int i, int* j)
        {
            i = 500;
            *j = 700;
        }

        static void Calc(int i, ref int j)
        {

        }
    }
}
