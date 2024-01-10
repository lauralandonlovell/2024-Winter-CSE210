using System;
using System.Collections.Generic;



//asking user for numbers
for (int i = 0; i <= 9; i++)
{
    List<int> numbers = new List<int>();

    //numbers from user
    Console.WriteLine("Enter a number: ");
    string number = Console.ReadLine();
    int numero = int.Parse(number);
    Console.WriteLine(numero);
    
    //filling list
    numbers.Add(numero);
    //Console.WriteLine(numbers);
}

