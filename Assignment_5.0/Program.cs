using System.Linq;
using System;

Que1 Ass5:
ans: -
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Intentionally dividing by zero to throw DivideByZeroException
            int numerator = 10;
            int denominator = 0;
            int result = DivideNumbers(numerator, denominator);

            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            // Handle the exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        // Check for zero denominator before performing division
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}


Que2 Ass5:
ans: -
 
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Creating an array with 5 elements
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Accessing an element at an index that is out of bounds
            int index = 10;
            int value = GetElementAt(index, numbers);

            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            // Handle the exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static int GetElementAt(int index, int[] array)
    {
        // Check if the index is within the bounds of the array
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of bounds.");
        }

        // Return the value at the specified index
        return array[index];
    }
}

Que3 Ass5:
Ans: -
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Attempting to convert a string to an integer
            string input = "abc";
            int result = ConvertStringToInt(input);

            Console.WriteLine($"Converted value: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            // Handle the exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static int ConvertStringToInt(string input)
    {
        // Attempt to convert the string to an integer
        return int.Parse(input);
    }
}
Que4 Ass5:
Ans: -
using System;

// Custom exception class
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simulating a condition that triggers the custom exception
            int number = -5;
            CheckPositiveNumber(number);

            Console.WriteLine($"Number is positive: {number}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"CustomException caught: {ex.Message}");
            // Handle the custom exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static void CheckPositiveNumber(int number)
    {
        // Check if the number is positive; if not, throw the custom exception
        if (number < 0)
        {
            throw new CustomException("Number must be positive.");
        }
    }
}

Que5 Ass5:
Ans: -
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulating different scenarios that may cause exceptions
            Console.WriteLine("Enter an index to access an array element:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = int.Parse(Console.ReadLine());
            AccessArrayElement(numbers, index);

            Console.WriteLine("Enter a number to parse:");
            string userInput = Console.ReadLine();
            int parsedNumber = ParseStringToInt(userInput);

            PerformOperation();

            Console.WriteLine($"Parsed number: {parsedNumber}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException caught: {ex.Message}");
            // Handle the exception gracefully for IndexOutOfRangeException
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException caught: {ex.Message}");
            // Handle the exception gracefully for FormatException
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
            // Handle the exception gracefully for InvalidOperationException
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Generic Exception caught: {ex.Message}");
            // Handle any other exceptions not specifically caught above
        }
    }

    static void AccessArrayElement(int[] array, int index)
    {
        // Attempt to access an element at the specified index in the array
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of bounds.");
        }

        Console.WriteLine($"Value at index {index}: {array[index]}");
    }

    static int ParseStringToInt(string input)
    {
        // Attempt to parse the string to an integer
        return int.Parse(input);
    }

    static void PerformOperation()
    {
        // Simulating an InvalidOperationException scenario
        throw new InvalidOperationException("Invalid operation.");
    }
}

Que6 Ass5:
Ans: -
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer Try Block Start");

            try
            {
                Console.WriteLine("Inner Try Block Start");

                // Simulating an exception in the inner block
                ThrowInnerException();

                Console.WriteLine("Inner Try Block End");
            }
            catch (Exception innerException)
            {
                Console.WriteLine($"Inner Catch Block: {innerException.Message}");
                // Handle the exception from the inner block in the outer block
                throw; // Rethrow the exception to be caught by the outer catch block
            }
            finally
            {
                Console.WriteLine("Inner Finally Block");
            }

            Console.WriteLine("Outer Try Block End");
        }
        catch (Exception outerException)
        {
            Console.WriteLine($"Outer Catch Block: {outerException.Message}");
            // Handle the exception caught from the inner block
        }
        finally
        {
            Console.WriteLine("Outer Finally Block");
        }

        Console.WriteLine("Program End");
    }

    static void ThrowInnerException()
    {
        // Simulating an exception in the inner block
        throw new ApplicationException("Exception in the inner block.");
    }
}

Que7 Ass5:
Ans: -
using System;

class Program
{
    static void Main()
    {
        bool validInput = false;

        do
        {
            try
            {
                Console.WriteLine("Enter the numerator:");
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the denominator:");
                int denominator = int.Parse(Console.ReadLine());

                // Check for division by zero
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                // Perform the division
                int result = numerator / denominator;

                Console.WriteLine($"Result of {numerator} / {denominator} = {result}");
                validInput = true; // Set to true if division is successful
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        } while (!validInput);

        Console.WriteLine("Program End");
    }
}
Que8 Ass5:
Ans: -
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulating an initial exception
            ThrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught in Main Catch Block: {ex.Message}");
            // Handle the rethrown exception appropriately
        }

        Console.WriteLine("Program End");
    }

    static void ThrowException()
    {
        try
        {
            // Simulating an exception
            int result = DivideNumbers(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Caught in ThrowException Catch Block: {ex.Message}");

            // Rethrow the caught exception
            Console.WriteLine("Rethrowing the exception...");
            throw; // The exception is rethrown and will be caught by the outer catch block
        }
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}
Que9 Ass5:
Ans: -
using System;

class Calculator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Simple Calculator");

            Console.WriteLine("Enter the first number:");
            double num1 = GetNumberFromUser();

            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = GetOperationFromUser();

            Console.WriteLine("Enter the second number:");
            double num2 = GetNumberFromUser();

            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double GetNumberFromUser()
    {
        string input = Console.ReadLine();
        if (!double.TryParse(input, out double number))
        {
            throw new FormatException("Invalid input. Please enter a valid number.");
        }
        return number;
    }

    static char GetOperationFromUser()
    {
        char operation;
        while (true)
        {
            string input = Console.ReadLine();
            if (input.Length == 1 && "+-*/".Contains(input[0]))
            {
                operation = input[0];
                break;
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
            }
        }
        return operation;
    }

    static double PerformOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return num1 / num2;
            default:
                throw new InvalidOperationException("Invalid operation.");
        }
    }
}
Que10 Ass5:
Ans: -
using System;

class ShoppingCart
{
    static void Main()
    {
        const int maxItems = 5;
        double[] cart = new double[maxItems];
        int itemCount = 0;

        Console.WriteLine("Welcome to the Shopping Cart!");

        try
        {
            while (itemCount < maxItems)
            {
                Console.WriteLine($"Enter the price of item #{itemCount + 1} (or type 'done' to finish):");
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                double price = ParsePrice(input);
                AddToCart(cart, ref itemCount, price);

                Console.WriteLine($"Item #{itemCount} added to the cart. Current total: {CalculateTotal(cart, itemCount)}");
            }

            Console.WriteLine($"Thank you for shopping! Your total is: {CalculateTotal(cart, itemCount)}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input: {ex.Message}");
        }
        catch (NegativePriceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double ParsePrice(string input)
    {
        if (!double.TryParse(input, out double price) || price < 0)
        {
            throw new FormatException("Invalid input. Please enter a valid positive price.");
        }

        return price;
    }

    static void AddToCart(double[] cart, ref int itemCount, double price)
    {
        if (price < 0)
        {
            throw new NegativePriceException("Invalid price. Price cannot be negative.");
        }

        cart[itemCount] = price;
        itemCount++;
    }

    static double CalculateTotal(double[] cart, int itemCount)
    {
        double total = 0;

        for (int i = 0; i < itemCount; i++)
        {
            total += cart[i];
        }

        return total;
    }
}

// Custom exception for negative prices
class NegativePriceException : Exception
{
    public NegativePriceException(string message) : base(message)
    {
    }
}

