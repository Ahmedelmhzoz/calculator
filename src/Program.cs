using Calculator;

public class Program
{
    private static int GetNumber() {
        string? input = Console.ReadLine();
        int number;
        while (!int.TryParse(input, out number)) {
            Console.Write('\n');
            Console.Write("Please enter an integer: ");
            input = Console.ReadLine();
        }
        return number;
    }
    private static int GetChoice() {
       int choice =  GetNumber();
       while (!ValidateInput.IsValidOperationChoice(choice)) {
           Console.Write('\n');
           Console.Write("Please enter valid choice: ");
           choice =  GetNumber();
       }
       return choice;
    }

    private static int ContinueOrNot() {
       int choice =  GetNumber();
       while (!ValidateInput.IsValidContinueChoice(choice)) {
           Console.Write('\n');
           Console.Write("Please enter valid choice: ");
           choice =  GetNumber();
       }
       return choice;
    } 
    private static bool StartProgram() {
        Console.Write("Please enter the first number: ");
        int number1 = GetNumber();
        Console.Write('\n');
        Console.Write("Please enter the second number: ");
        int number2 = GetNumber();
        Console.Write('\n');
        Console.Write("What operation you want to perform? [1]Add [2]Subtract [3]Multiply [4]Divide: ");
        int choice = GetChoice();
        Operation currentOperation = (Operation)choice;
        try {
            Console.WriteLine($"The result = {Calc.Calculate(number1, number2, currentOperation)}");
        }
        catch {
            Console.WriteLine("Cannot divide by 0");
        }
        Console.Write("Wanna use calculator again? [1]Yes [2]No: ");
        choice = ContinueOrNot();
        return choice == 1;
    }
    
    static void Main(string[] args) {
        while (StartProgram()) {
            Console.Clear();
            Console.WriteLine("TEST");
        }
    }
}