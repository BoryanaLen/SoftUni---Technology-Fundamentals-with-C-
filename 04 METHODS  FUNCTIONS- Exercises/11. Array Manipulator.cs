using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static int[] Exchange(int [] arrayNumbers, int index)
        {
            int[] firstArray = arrayNumbers.Take(index + 1).ToArray();
            int[] secondArray = arrayNumbers.Skip(index + 1).ToArray();

            int[] newArray = secondArray.Concat(firstArray).ToArray();

            return newArray;         
        }

        static int MaxEven (int[] arrayNumbers)
        {
            int maxEvenNumber = int.MinValue;
            int indexMaxEven = -1;

            for(int i = 0; i<arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == 0)
                {
                    if (arrayNumbers[i] >= maxEvenNumber)
                    {
                        maxEvenNumber = arrayNumbers[i];
                        indexMaxEven = i;
                    }
                }
            }

            return indexMaxEven; ;
        }

        static int MinEven(int[] arrayNumbers)
        {
            int minEvenNumber = int.MaxValue;
            int indexMinEven = -1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == 0)
                {
                    if (arrayNumbers[i] <= minEvenNumber)
                    {
                        minEvenNumber = arrayNumbers[i];
                        indexMinEven = i;
                    }
                }
            }

            return indexMinEven; ;
        }

        static int MaxOdd(int[] arrayNumbers)
        {
            int maxOdd = int.MinValue;
            int indexMaxOdd = -1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 != 0)
                {
                    if (arrayNumbers[i] >= maxOdd)
                    {
                       maxOdd = arrayNumbers[i];
                        indexMaxOdd = i;
                    }
                }
            }

            return indexMaxOdd;
        }

        static int MinOdd(int[] arrayNumbers)
        {
            int minOdd = int.MaxValue;
            int indexMinOdd = -1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 != 0)
                {
                    if (arrayNumbers[i] <= minOdd)
                    {
                        minOdd = arrayNumbers[i];
                        indexMinOdd = i;
                    }
                }
            }

            return indexMinOdd;
        }

        static string FirstCountEven(int[] arrayNumbers, int count) 
        {
            int firstCountEven = 0;
            int[] arrayCountEven = new int[count];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == 0)
                { 
                    arrayCountEven[firstCountEven] = arrayNumbers[i];
                    firstCountEven++;
                }

                if (firstCountEven == count)
                {
                    break;
                }
            }

            if(firstCountEven == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", arrayCountEven.Take(firstCountEven));
            }          
        }

        static string FirstCountOdd(int[] arrayNumbers, int count)
        {
            int firstCountOdd = 0;
            int[] arrayCountOdd = new int[count];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 != 0)
                {
                    arrayCountOdd[firstCountOdd] = arrayNumbers[i];
                    firstCountOdd++;
                }

                if (firstCountOdd == count)
                {
                    break;
                }
            }

            if (firstCountOdd == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", arrayCountOdd.Take(firstCountOdd));
            }
        }

        static string LasttCountEven(int[] arrayNumbers, int count)
        {
            int lastCountEven = 0;
            int[] arrayCountEven = new int[count];

            for (int i = arrayNumbers.Length -1; i >= 0; i--)
            {
                if (arrayNumbers[i] % 2 == 0)
                {
                    arrayCountEven[lastCountEven] = arrayNumbers[i];
                    lastCountEven++;
                }

                if (lastCountEven == count)
                {
                    break;
                }
            }

            if (lastCountEven == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", arrayCountEven.Take(lastCountEven).Reverse());
            }
        }


        static string LasttCountOdd(int[] arrayNumbers, int count)
        {
            int lastCountOdd = 0;
            int[] arrayCountOdd = new int[count];

            for (int i = arrayNumbers.Length - 1; i >= 0; i--)
            {
                if (arrayNumbers[i] % 2 != 0)
                {
                    arrayCountOdd[lastCountOdd] = arrayNumbers[i];
                    lastCountOdd++;
                }

                if (lastCountOdd == count)
                {
                    break;
                }
            }

            if (lastCountOdd == 0)
            {
                return string.Empty;
            }
            else
            {
                return string.Join(", ", arrayCountOdd.Take(lastCountOdd).Reverse());
            }
        }


        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    string newArrayString = string.Join(", ", arrayNumbers);
                    Console.WriteLine($"[{newArrayString}]");
                    break;
                }

                string[] commandText = command.Split(' ').ToArray();

                if(commandText[0] == "exchange")
                {
                    if (int.Parse(commandText[1]) > (arrayNumbers.Length - 1) || int.Parse(commandText[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                       arrayNumbers = Exchange(arrayNumbers, int.Parse(commandText[1]));
                    }
                }
                else if(commandText[0] == "min" && commandText[1] == "even")
                {
                    int minEven = MinEven(arrayNumbers);

                    if(minEven == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEven);
                    }
                }
                else if (commandText[0] == "min" && commandText[1] == "odd")
                {
                    int minOdd = MinOdd(arrayNumbers);

                    if (minOdd == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOdd);
                    }
                }
                else if (commandText[0] == "max" && commandText[1] == "even")
                {
                    int maxEven = MaxEven(arrayNumbers);

                    if (maxEven == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEven);
                    }
                }
                else if (commandText[0] == "max" && commandText[1] == "odd")
                {
                    int maxOdd = MaxOdd(arrayNumbers);

                    if (maxOdd == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOdd);
                    }
                }
                else if(commandText[0] == "first" && commandText[2] == "odd")
                {
                    if (int.Parse(commandText[1]) > arrayNumbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{FirstCountOdd(arrayNumbers, int.Parse(commandText[1]))}]");
                    }
                }
                else if (commandText[0] == "first" && commandText[2] == "even")
                {
                    if (int.Parse(commandText[1]) > arrayNumbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{FirstCountEven(arrayNumbers, int.Parse(commandText[1]))}]");
                    }
                }
                else if (commandText[0] == "last" && commandText[2] == "odd")
                {
                    if (int.Parse(commandText[1]) > arrayNumbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{LasttCountOdd(arrayNumbers, int.Parse(commandText[1]))}]");
                    }
                }
                else if (commandText[0] == "last" && commandText[2] == "even")
                {
                    if (int.Parse(commandText[1]) > arrayNumbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{LasttCountEven(arrayNumbers, int.Parse(commandText[1]))}]");
                    }
                }
            }
        }
    }
}
