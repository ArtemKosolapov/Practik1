Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1>number2 && number1>number3)
Console.WriteLine(number1);

if (number2>number1 && number2>number3)
Console.WriteLine(number2);

if (number3>number1 && number3>number2)
Console.WriteLine(number3);

Console.ReadLine();