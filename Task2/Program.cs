namespace Options
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<int> list = new List<int>();

            char option;
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Display the largest number");
                Console.WriteLine();
                Console.Write("Enter Your choice: ");
                option = char.Parse(Console.ReadLine().ToUpper());
                switch (option)
                {
                    case 'P':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.Write($"{list[i]} ");
                            }
                            Console.WriteLine("]");
                        //   Console.WriteLine($"[ {string.Join(" ", list)} ]");
                        }

                        break;
                    case 'A':
                        Console.Write("Enter the number to add: ==> ");
                        int input = int.Parse(Console.ReadLine());
                        list.Add(input);
                        Console.WriteLine($"{input} added");
                        Console.WriteLine();
                        break;
                    case 'M':
                        double sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine($"{sum / list.Count}");

                        break;
                    case 'S':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest - list is empty");
                        }
                        else
                        {
                            int smallest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] < smallest)
                                    smallest = list[i];
                            }
                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        Console.WriteLine();
                        break;
                    case 'L':
                        Console.WriteLine("L");
                        break;
                    case 'Q':
                        Console.WriteLine("Q");
                        break;
                    default:
                        Console.WriteLine("Unknown selection, Please try again");
                        break;
                }
            }
            while (option != 'Q');
        }
    }
}

