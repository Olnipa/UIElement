namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healthBarPosition = 0;
            int manaBarPosition = 40;
            int healthPercent = 0;
            int manaPercent = 0;
            bool isWorking = true;

            while (isWorking)
            {
                DrawBar(healthPercent, "Здоровье", ConsoleColor.Red, healthBarPosition);
                DrawBar(manaPercent, "Мана", ConsoleColor.Blue, manaBarPosition);

                Console.WriteLine("\n");
                healthPercent = ReadNumber("Укажите остаток жизней от 0 до 100%: ");
                manaPercent = ReadNumber("Укажите остаток маны от 0 до 100%: ");
                Console.Clear();
            }
        }
        static void DrawBar(int valuePercent, string name, ConsoleColor color, int position, int maxvalue = 20)
        {
            Console.SetCursorPosition(position, 3);
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            int value = maxvalue * valuePercent / 100;

            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            Console.Write($"{name} [");
            Console.BackgroundColor = color;
            Console.Write(bar);
            bar = "";

            for (int i = value; i < maxvalue; i++)
            {
                bar += ' ';
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            Console.Write("]");
        }
        static int ReadNumber(string message)
        {
            int value = -1;
            int minValue = 0;
            int maxValue = 100;

            while (value < minValue || value > maxValue)
            {
                Console.Write(message);
                value = Convert.ToInt32(Console.ReadLine());

                if (value < minValue || value > maxValue)
                {
                    Console.WriteLine("Вы ввели недопустимое значение. Пожалуйста, введите значение от 0 до 100.");
                }
                else
                {
                    break;
                }
            }
            
            return value;
        }
    }
}
