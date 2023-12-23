
class Program
{
    static int[] numbers = new int[] { 10, 32, 43, 65, 23, 7, 3, 76, 24, 4 };
    static void Main(string[] args)
    {
        Console.WriteLine("Inicio");
        Show();

        int intIteration = 0;
        int extIteration = 0;

        bool flag = true;
        for(int i= 0; i<numbers.Length && flag; i++)
        {
            flag = false;
            extIteration++;
            for(int j=0; j<numbers.Length-i -1; j++)
            {
                intIteration++;
                if (numbers[j] > numbers[j + 1])
                {
                    flag = true;
                    int aux = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = aux;
                }
            }
            Show();
        }
        Console.WriteLine();
        Console.WriteLine("Iteraciones externas: " + extIteration);
        Console.WriteLine("Iteraciones internas: " + intIteration);
    }

    public static void Show()
    {
        foreach(var number in numbers)
        {
            Console.WriteLine(number + ",");
        }
        Console.WriteLine("\n");
    }
}