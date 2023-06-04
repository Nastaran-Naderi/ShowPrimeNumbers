System.Console.WriteLine(long.MaxValue);
System.Console.WriteLine(long.MaxValue.ToString("#,##0"));

System.Console.Write("What is you number: ");
string maxNumberString = System.Console.ReadLine();
long maxNumber = System.Convert.ToInt64(maxNumberString);

long primeNumberCount = 0;

for (long number = 1; number <= maxNumber; number++)
{
    bool isPrimeNumber = true;

    for (long index = 2; index <= number - 1; index++)
    {
        if (number % index == 0)
        {
            isPrimeNumber = false;

            break;
        }
    }

    if (isPrimeNumber)
    {
        primeNumberCount++;
        System.Console.WriteLine(number);
    }
}

System.Console.WriteLine($"The prime number count is {primeNumberCount}");