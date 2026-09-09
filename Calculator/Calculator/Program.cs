Console.WriteLine("Enter number 1:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number 2:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose *,/,+,-");
string  sign = Console.ReadLine();
double result =0;
if (sign == "*") {
  result =  num1* num2;
}

if (sign == "/")
{
    result = num1/num2;
}

if (sign == "+")
{
    result = num1+num2;
}

if (sign == "-")
{
    result = num1-num2;
}

Console.WriteLine(result);



