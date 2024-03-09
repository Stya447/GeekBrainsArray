
Console.Write("Введите массив строк через запятую: ");
string[] input = Console.ReadLine().Split(",");
GetElementsWithLengthEqualsOrLessThan3(input);
Console.ReadLine();

string[] GetElementsWithLengthEqualsOrLessThan3(string[] args)
{
    string[] newArgs = new string[args.Length];
    int counter = 0;
    for (int i = 0; i < args.Length; i++)
    {
        if (args[i].Length <= 3)
        {
            newArgs[counter] = args[i];
            counter++;
        }
    }
    
    Console.Write("Ответ: ");
    for(int i=0;i< newArgs.Length;i++)
        Console.Write(newArgs[i] + " ");
    Console.WriteLine(); 
    
    return newArgs;
}