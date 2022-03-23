using System;

namespace Homework
{
    class Delegate
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            Console.WriteLine("Привет, напиши любой символ)");
            var a = Console.ReadKey();
            while (true)
            { 
                if (a.Key == ConsoleKey.C) 
                {
                    Console.WriteLine("Завершаем выполнение цикла");
                    break;//завершаем выполнение цикла
                }
                else
                {
                 OnKeyPressed?.Invoke(this, a.KeyChar);//Вызов события OnKeyPressed
                } 
            }
        }
    }

    class Work 
    {
        static void Main(string[] args)
        {
            var b = new Work();
            b.Add();
        }
        public void Write(object sender, char letter)
        {
            Console.WriteLine(letter);
        }
        public void Add()
        {
            var c = new Delegate();

            c.OnKeyPressed += Write;
            c.Run();
        }

    }
}
