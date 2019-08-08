using System;

class Mealtime
{
    static void Main()
    {
        WhatAreYouEating("breakfast");
        WhatAreYouEating("Lunch");
        WhatAreYouEating("Dinner");

        
    }

    static void WhatAreYouEating(string meal)
    {
        Console.WriteLine("What are you eating for "+meal+".");
        string yourMeal = Console.ReadLine();
        Console.WriteLine("You had "+yourMeal+" for "+meal+".");
    }
}