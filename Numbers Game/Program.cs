namespace Numbers_Game;
//Time: 8 hours

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        StartSequence();
    }

    static void StartSequence()
    {
        int[] numberArray = new int[4]; //Declare array of four zeroes
        int[] populateResult = Populate(numberArray); //Call Populate method
        int sum = GetSum(populateResult);
        Console.WriteLine(sum);

        for (int i = 0; i < populateResult.Length; i++) //Loop through array and console.write elements
        {
            Console.Write(populateResult[i] + " ");
        }

        int product = GetProduct(populateResult, sum);
        GetQuotient(product);
    }

    static int[] Populate(int[] array)
    {
        //Loop through array and promt user fro values
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Give me a number");
            string userInput = Console.ReadLine();
            int number = Int32.Parse(userInput);
            array[i] = number;
        }
        return array;
    }

    static int GetSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        //If the sum of numbers is less than the number 20 then an error is caught saying the sum is to low
        if (sum < 20)
        {
            throw new Exception("Number is too low");
        }
        return sum;
    }

    static int GetProduct(int[] array, int sum)
    {
        Console.WriteLine("Pick a random number between 1 and {0}", array.Length);
        string randomIndex = Console.ReadLine();
        int randomIndexInt = Int32.Parse(randomIndex) - 1;
        //If the index chosen is larger than the length of the array then an error is caught saying the Index is out of range of the length of the Array
        if (randomIndexInt > array.Length)
        {
            throw new Exception("Index is out of range");
        }
        int randomeIndex = array[randomIndexInt];

        int randomNumber = array[randomIndexInt];
        Console.WriteLine("Random number is {0}", randomNumber);

        //multiply
        int product = randomNumber * sum;
        Console.WriteLine("This is the product {0}", product);

        return product;
    }


    static decimal GetQuotient(int product)
    {
        //Prompt user for number to divide product by
        Console.WriteLine("Give me a number to divide the product by");
        string userInput = Console.ReadLine();
        int divisor = Int32.Parse(userInput);
        decimal quotient = product / divisor;

        Console.WriteLine("This is the Quotient:{0}", quotient);
        return quotient;
    }

}