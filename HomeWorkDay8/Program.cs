// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please write the first number!");
string numb1String = Console.ReadLine();
bool numb1Parsed = double.TryParse(numb1String, out double numb1);
Console.WriteLine("Please write the mathematical action to be performed!");
string actionString = Console.ReadLine();
bool actionParsed = char.TryParse(actionString, out char action);
Console.WriteLine("Please write the second number!");
string numb2String = Console.ReadLine();
bool numb2Parsed = double.TryParse(numb2String, out double numb2);


switch (action)
    {
    case '+':
        Console.WriteLine($"The sum is {numb1 + numb2}.");
        break;
    case '-':
        Console.WriteLine($"The difference is {numb1 - numb2}.");
        break;
    case '/':
        Console.WriteLine($"The quotient is {numb1 / numb2}.");
        break;
    case '*':
        Console.WriteLine($"The product is {numb1 * numb2}.");
        break;
    case '%':
        Console.WriteLine($"The remainder is {numb1 % numb2}.");
        break;
    case 'p':
        Console.WriteLine($"The elements are {numb1}, {numb2}.");
        break;
    case 'b':
        if (numb1 > numb2)
        { Console.WriteLine($"The bigger element is {numb1}."); }
        else if (numb1 < numb2)
        { Console.WriteLine($"The bigger element is {numb2}."); }
        else { Console.WriteLine("Both elements are the same.");}
            break;
    case 's':
        if (numb1 > numb2)
        { Console.WriteLine($"The smaller element is {numb2}."); }
        else if (numb1 < numb2)
        { Console.WriteLine($"The smaller element is {numb1}."); }
        else { Console.WriteLine("Both elements are the same."); }
        break;
    default:
        Console.WriteLine("Please check the action you chose. It is not valid.");
        break;
}