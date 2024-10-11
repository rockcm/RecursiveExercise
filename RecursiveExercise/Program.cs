// answer to week 5 feedback: try parse better for user input as it handles exceptions
// try catch to handle format errors like letters being input
try
{
    // user enters first number 
    Console.WriteLine("Enter the first number: ");
    int number1 = int.Parse(Console.ReadLine());
    // get absolute value in case neg number is entered
    int numberAbs1 = Math.Abs(number1);

    // user enters second number 
    Console.WriteLine("Enter the second number: ");
    int number2 = int.Parse(Console.ReadLine());
    //get absolute value in case neg number is entered
    int numberAbs2 = Math.Abs(number2);


    // add numbers together 
    int sum = numberAbs1 + numberAbs2;

    // call method to reduce 
    int result = ReduceToSingleDigit(sum);

    // print result
    Console.WriteLine($"The single digit result is: {result}");
}
catch (FormatException e) // catch format exceptions
{
    // print exe
    Console.WriteLine(e.Message);
    Console.WriteLine("Please enter a number, not a letter or anything else.");
}
// method to reduce number to single digit 
static int ReduceToSingleDigit(int number)
{
   


        // if number is already single digit return
        if (number < 10)
        {
            return number;
        }

        // extract the last digit using mod instead of string manipulation which is likely slower
        int lastDigit = number % 10;       // get the last digit
        int remainingDigits = number / 10; // remove the last digit and keep remaining 

        // add last digit to the remaining 
        int sum = lastDigit + remainingDigits;

        // recursively reduce to single digit 
        return ReduceToSingleDigit(sum);
}
  
