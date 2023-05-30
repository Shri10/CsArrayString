namespace CsArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Array, and Strings Programs:\nPlease Chose from below options:");

            int[] arr = { 1, 9, 2, 3, 4, 2, 3, 4, 5, 6, 2, 7, 8, 5, 9, 1 };
            while (true)
            {
                Console.WriteLine("\nPlease choose from below options:");
                Console.WriteLine("1. Count duplicate elements in an array");
                Console.WriteLine("2. Print unique elements in an array");
                Console.WriteLine("3. Count frequency of each element in an array");
                Console.WriteLine("4. Find maximum and minimum elements in an array");
                Console.WriteLine("5. Print Triangular star pattern");
                Console.WriteLine("6. Print rectangle pattern");
                Console.WriteLine("7. Reverse each word in a string");
                Console.WriteLine("8. Find sum of all digits of a number");
                Console.WriteLine("0. Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        //Option 1
                        //Add option to chose from predefined array, or define your custom array.
                        DuplicateElements.DuplicateCount(arr);
                        break;
                    case 2:

                        //Option 2
                        //Add option to chose from predefined array, or define your custom array.
                        PrintUnique.PrintUniqOnly(arr);
                        break;
                    case 3:

                        //Option 3
                        //Add option to chose from predefined array, or define your custom array.
                        CountFreq.Freq(arr);
                        break;
                    case 4:

                        //Option 4
                        //Add option to chose from predefined array, or define your custom array.
                        MaxMin.MM(arr);
                        break;
                    case 5:

                        //Option 5
                        StarPattern.starPatt();
                        break;
                    case 6:

                        //Option 6
                        RectPattern.rectPatt();
                        break;
                    case 7:

                        //Option 7
                        //ReverseWords.RevWords("Welcome to C# Array, and Strings Programs Please Chose from below options.");
                        string reversedWords = ReverseWords.RevWords("Welcome to C# Array, and Strings Programs Please Chose from below options.");
                        Console.WriteLine(reversedWords);
                        break;
                    case 8:

                        //Option 8
                        SumOfDigits.SOD(654);
                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            }
        }
    }
}