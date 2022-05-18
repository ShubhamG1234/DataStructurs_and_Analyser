
Console.WriteLine("Welcome to Reverse Numbers !");

{
    int num = 0;
    int temp = 0;
    int remainder = 0;
    int reverse = 0;
    {
        Console.WriteLine("Enter an Integer \n");
    }
    num = Convert.ToInt32(Console.ReadLine());

    temp = num;
    while (num > 0)
    {
        remainder = num % 10;
        reverse = reverse * 10 + remainder;
        num /= 10;
    }
    Console.WriteLine("Given Number is = {0}", temp);
    Console.WriteLine("Its Reverse is = {0}", reverse);
}