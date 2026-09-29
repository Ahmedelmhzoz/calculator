namespace Calculator;
public static class ValidateInput{
    public static bool IsValidOperationChoice(int choice2) {
        return choice2 > 0 &&  choice2 <= 4;
    }
    public static bool IsValidContinueChoice(int choice2) {
        return choice2 > 0 &&  choice2 <= 2;
    }
}