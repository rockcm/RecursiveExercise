Console.WriteLine("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());


int sum = number1 + number2;


int result = ReduceToSingleDigit(sum);


Console.WriteLine($"The single digit result is: {result}");
    

   
    static int ReduceToSingleDigit(int number)
{
    //base
    if (number < 10)
    {
        return number;
    }

    
    string numberString = number.ToString();
    char lastDigitChar = numberString[numberString.Length - 1];

  
    int lastDigit = int.Parse(lastDigitChar.ToString());
    int remainingDigits = number / 10; 

   
    int sum = lastDigit + remainingDigits;

  
    return ReduceToSingleDigit(sum);
}