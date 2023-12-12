public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] inputValues = input.Split();
        if (inputValues.Length < 3)
        {
            Console.WriteLine("Invalid input. Please provide the type followed by two values.");
            return;
        }
        string type = inputValues[0].ToLower();
        string value1 = inputValues[1];
        string value2 = inputValues[2];
        switch (type)
        {
            case "int":
                int num1 = int.Parse(value1);
                int num2 = int.Parse(value2);
                Console.WriteLine("The greater value is: " + GetMax(num1, num2));
                break;
           case "char":
                char char1 = char.Parse(value1);
               char char2 = char.Parse(value2);
                Console.WriteLine("The greater character is: " + GetMax(char1, char2));
                break;
            case "string":
                Console.WriteLine("The greater string is: " + GetMax(value1, value2));
                break;
            default:
                Console.WriteLine("Invalid type. Please use 'int', 'char', or 'string'.");
                break;
        }
    }
    private static T GetMax<T>(T value1, T value2) where T : IComparable<T>
    {
        return value1.CompareTo(value2) >= 0 ? value1 : value2;
    }
}