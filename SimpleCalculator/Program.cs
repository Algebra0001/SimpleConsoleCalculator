// See https://aka.ms/new-console-template for more information

using SimpleCalculator;
using CalcLib;

double firstNum = 0;
double secondNum = 0;
double result = 0;
int sign = 0;
int counts = 1;

var calcOptrs = new CalcOperators();

DisplayHeader();
DisplayOperators();

while (true)
{

    if (counts >= 2)
    {
        Console.WriteLine();
        int choice = 0;
        Console.WriteLine("Press 1 to continue, Press 2 to clear screen, Press 3 to exit");
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            HandleDecision(choice.ToString());
        }
        else
            DisplayErrMessage();
    }
    else
    {
        SetInputs();
    }

    result = calcOptrs.Calc(sign, firstNum, secondNum);

    Console.WriteLine($"Your answer is: {result}");

    counts++;
}





void DisplayHeader()
{
    MyUtils.CenterText("Week 1, task solution");
    MyUtils.CenterText("Simple Calculator");
}

void DisplayOperators()
{
    Console.WriteLine();
    Console.WriteLine(@"
Press 1  ==>  +
Press 2  ==>  -
Press 3  ==>  *
Press 4  ==>  /
");
    Console.WriteLine("Select an operator");
    if (int.TryParse(Console.ReadLine(), out sign))
    {
        if(sign < 1 || sign > 4)
        {
            Console.WriteLine("Invalid entry!");
            Environment.Exit(0);
        }
    }
    else
        DisplayErrMessage();
}

void SetInputs()
{
    Console.Write("Enter first number\t");
    if(!double.TryParse(Console.ReadLine(), out firstNum))
    {
        DisplayErrMessage();
    }

    Console.Write("Enter second number\t");
    if (!double.TryParse(Console.ReadLine(), out secondNum))
    {
        DisplayErrMessage();
    }
}

void DisplayErrMessage(){
    Console.WriteLine("Error: expected a digit value");
    Environment.Exit(0);
}

void HandleDecision(string nextChoice)
{
   
    switch (nextChoice)
    {
        case "1":
            Console.Clear();
            DisplayHeader();
            DisplayOperators();
            Console.WriteLine("Continue by providing just the second value");
            if (!double.TryParse(Console.ReadLine(), out secondNum))
            {
                DisplayErrMessage();
            }
            firstNum = result;
            break;
        case "2":
            Console.Clear();
            DisplayHeader();
            DisplayOperators();
            SetInputs();
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid entry!");
            Environment.Exit(1);
            break;
    }
   
}