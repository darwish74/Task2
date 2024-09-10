namespace Options
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<int> list = new List<int>() {10,5,22,11,55,88,99,2};

            char option;
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Search for the number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("U - Sum of numbers in the list");
                Console.WriteLine("D - Order numbers in the list descending order");
                Console.WriteLine("G - Order numbers in the list ascending order");
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
                        bool flag2 = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (input == list[i])
                            {
                                flag2 = true;
                                break;
                            }        
                        }
                        if (flag2)
                        {
                        Console.WriteLine("This number is exist already");
                        }
                        else
                        {
                            list.Add(input);
                            Console.WriteLine($"{input} added");
                            Console.WriteLine();
                        }
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
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
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
                        break;
                    case 'L':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > largest)
                                    largest = list[i];
                            }
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;
                    case 'F':
                        Console.Write("Please enter the number: ");
                        int num = int.Parse( Console.ReadLine() ); 
                        bool flag = false;
                        int position=0;
                        for (int i = 0;i<list.Count;i++)
                        {
                            if (list[i] == num)
                            {
                                flag = true;
                                position = i;
                            }
                        }
                        if(flag)
                        {
                            Console.WriteLine($"This number {num} is found in index : {position}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry,This number {num} not found");
                        }
                        break;
                    case 'C':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty already");
                        }
                        else
                        {
                            list.Clear();
                            Console.WriteLine("List is cleared");
                        }
                        break;
                    case 'U':
                        int total = 0;
                        for (int i =0;i<list.Count; i++)
                        {
                            total += list[i];
                        }
                        Console.WriteLine($"Sum of list is {total}");
                        break;
                    case 'D':  //{2,1,4,3,5}
                        for (int i=0; i < list.Count; i++)
                        {
                            for(int  j=0;j<list.Count-1;j++)
                            {
                                if (list[j] < list[j+1])
                                {
                                    int temp = list[j + 1];
                                    list[j+1] = list[j];
                                    list[j+1] = temp;
                                }
                            }
                        }
                        for(int i=0;i<list.Count;i++)
                        {
                            Console.WriteLine(list[i]);
                        }

                    
                        break;
                    case 'Q':
                            Console.WriteLine("Goodbye");
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

