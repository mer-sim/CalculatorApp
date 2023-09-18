// Output 
Console.WriteLine("Hello, World!");

// Input first number
Console.WriteLine("Please enter first number: ");
var firstNumberInput = double.Parse(Console.ReadLine());

// Input second number
Console.WriteLine("Please enter second number: ");
var secondNumberInput = double.Parse(Console.ReadLine());

// Input operator
Console.WriteLine("Please enter operator (+,-,/,*): ");
var operatorInput = Console.ReadLine();

// Initalize empty double variable
double result = 0;

// Switch case
switch (operatorInput)
{
  case "+":
    result = firstNumberInput + secondNumberInput;
    break;
  case "-":
    result = firstNumberInput - secondNumberInput;
    break;
  case "/":
    result = firstNumberInput / secondNumberInput;
    break;
  case "*":
    result = firstNumberInput * secondNumberInput;
    break;
}

// Output
Console.WriteLine("The result is " + result);