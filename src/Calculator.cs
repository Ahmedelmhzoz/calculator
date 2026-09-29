namespace Calculator;
public class Calc{
    public static double Calculate(int number1, int number2, Operation operation) {
        switch (operation) {
            case Operation.Add:
                return number1 + number2;
            case Operation.Subtract:
                return number1 - number2;
            case Operation.Mul:
                return number1 * number2;
            case Operation.Divide:
                if (number2 == 0)
                    throw new DivideByZeroException();
                return (double)number1 / number2;
            default:
                return 0;
        }
    }
}