internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu();
    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) The second number ");
        Console.WriteLine("2) The third number");
        Console.WriteLine("3) Day of the week");
        Console.WriteLine("4) Prime numbers");
        Console.WriteLine("5) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
                int num = new Random().Next(100, 1000);// переменная для проверки
                Console.WriteLine($"{num} -> {SecNum(num)}");
                return true;
            case "2":
                //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
                Console.Clear();
                Console.Write("Enter a number: ");
                int myNumb = int.Parse(Console.ReadLine());
                int res = 0;
                int tmp = NumCouter(myNumb);
                if (tmp >= 3)
                {
                    res = ThirdNumb(tmp, myNumb);
                    Console.WriteLine($"{myNumb} -> {res}");
                }
                else Console.WriteLine($"{myNumb} -> Do not have third number.");
                return true;
            case "3":
                /*Напишите программу, которая принимает на вход цифру, 
                обозначающую день недели, и проверяет, является ли этот день выходным.*/
                Console.WriteLine("Enter a number of day: ");
                int day = int.Parse(Console.ReadLine());
                if (day > 5 && day < 8) Console.WriteLine($"{day} -> yes");
                else Console.WriteLine($"{day} -> no");
                return true;
            case "4":
                /*Напишите программу, которая принимает на вход число N 
                и выводит все простые числа в промежутке от 0 до N (включительно)*/
                Console.Clear();
                Console.WriteLine("Enter a number: ");
                myNumb = int.Parse(Console.ReadLine());
                Console.Write($"Prime numbers in the range from 0 to {myNumb}: ");
                int start = 2;
                while(start <= myNumb){
                    if(IsPrime(start)) Console.Write(start+" ");
                    start++;
                }
                return true;
            case "5":
                return false;
            default:
                return false;
        }

    }
    /// <summary>
    /// Определение 2ой переменной
    /// </summary>
    /// <param name="myNumd"></param>
    /// <returns></returns>
    private static int SecNum(int myNumd)
    {
        int secondNum = myNumd / 10 % 10;
        return secondNum;
    }
    /// <summary>
    /// Количество цифр в числе
    /// </summary>
    /// <param name="entNumber"></param>
    /// <returns></returns>
    private static int NumCouter(int entNumber)
    {
        int count = 0;
        while (entNumber > 0)
        {
            entNumber /= 10;
            count++;
        }
        return count;
    }
    /// <summary>
    /// Поиск третьего числа
    /// </summary>
    /// <param name="countFunk"></param>
    /// <param name="entNumber"></param>
    /// <returns></returns>
    private static int ThirdNumb(int countFunk, int entNumber)
    {
        int multip = 1;
        while (countFunk - 2 > 1)
        {
            multip *= 10;
            countFunk--;
        }
        int thirdNumb = entNumber / multip % 10;
        return thirdNumb;
    }
    /// <summary>
    /// Проверка на простое число
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
    
