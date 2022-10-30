namespace Pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Zakaz zakaz = new Zakaz();
                zakaz.Create();
                zakaz.SaveToFile("D:\\История заказов.txt");
                Console.WriteLine("Ваш заказ сформирован! Чтобы сформировать ещё один заказ нажмите Enter.");
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Enter);
        }
    }
}