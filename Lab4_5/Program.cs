namespace Program
{
    public abstract class Program1
    {
        protected abstract void Start();
        protected abstract void Menu();
        protected abstract void Close();
        protected abstract void Odin();
        protected abstract void Mnogo();
        protected abstract void Res();
    }
    public class Program2 : Program1
    {
        private static List<int> list = new List<int>();
        private static int dlin;
        protected override void Start()
        {
            Console.WriteLine("Введите длинну массива");
            int dlin1 = int.Parse(Console.ReadLine());
            dlin = dlin1;
        }
        protected static void Nach()
        {
            Console.WriteLine($"Массив");
            for (int i = 0; i < dlin; i++)
            {
                list.Add(i);
                Console.Write($"{list[i]} ");
            }
        }
        protected override void Menu()
        {
            Nach();
            Console.WriteLine($"\nНамира объектов");
            for (int i = 0; i < dlin; i++)
            {
                Console.Write($"[{list[i]}] ");
            }

            Console.WriteLine("\nВведите номер связанного объекта.");
            int svas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Впереди стоящие");
            for (int i = svas + 1; i < dlin; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine($"\nПозади стоящие");
            for (int i = svas - 1; i >= 0; i--)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine("\n1) Связь одни к однаму.\n2) Множественная связь.\n3) Результат.");
            int q = int.Parse(Console.ReadLine());
            switch (q)
            {
                case 1:
                    Odin();
                    break;
                case 2:
                    Mnogo();
                    break;
                case 3:
                    Res();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        protected override void Close()
        {
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        protected override void Odin()
        {
            for (int i = 0; i < dlin - 1; i++)
            {
                Console.WriteLine($"Объект: {i} стоит перед {i + 1}");
            }
            Close();
        }

        protected override void Mnogo()
        {
            Console.WriteLine($"После {list[0]} стоит {list[1]}");
            for (int i = 1; i < dlin - 2; i++)
            {
                Console.WriteLine($"Перед {i} стоит {i - 1} после {i + 1}");
            }
            Console.WriteLine($"Перед {dlin - 1} стоит {dlin - 2}");
            Close();
        }
        protected override void Res()
        {
            Console.Clear();


            Console.WriteLine($"Связанные обюъекты.");

            for (int i = dlin - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Не связанные обюъекты.");

            for (int i = 0; i < dlin; i++)

            {

                Console.WriteLine(i);
            }
            Console.WriteLine($"Объекты со множеством связий");
            for (int i = 0 + 1; i < dlin - 1; i++) Console.WriteLine(i);
        }
        public Program2()
        {
            Start();
            Menu();
        }
    }
    public class ProgramMain // Основна функция.
    {
        static void Main()
        {
            Program2 program1 = new Program2();
        }
    }
}