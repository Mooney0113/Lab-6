

using System.Numerics;
using System.Xml.Schema;

Random rng  = new Random(4000) ;

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");


System.Console.WriteLine("Choose 1 through 5: ");
int choice = Convert.ToInt32(Console.ReadLine()) ;


while (choice < 1 || choice > 5 )
{
    System.Console.Write("Choose a number from 1 through 5: ");
     choice = Convert.ToInt32(Console.ReadLine()) ;
}

if (choice == 1 || choice == 4 )
{
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===" );

    System.Console.Write("Score :");
    int score = Convert.ToInt32(Console.ReadLine()) ;

    while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ") ; 
        score = Convert.ToInt32(Console.ReadLine()) ;
    }

    if (score >= 90)
    {
        System.Console.WriteLine(score + " earns an A");
    }
    else if (score >= 80)
    {
        System.Console.WriteLine(score + " earns a B");
    }
    else if (score >= 70)
    {
        System.Console.WriteLine(score + " earns a C");
    }
    else if (score >= 60)
    {
        System.Console.WriteLine(score + " earns a D");
    }
    else
    {
        System.Console.WriteLine(score + " earns an F");
    }
}
if (choice == 2 || choice == 4)
{
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    int rollCount = 0;
    int winCount = 0;
    string rollAgain;
    

    do
    {
        int die1 = rng.Next(1, 7);
        int die2 = rng.Next(1, 7);

        int total = die1 + die2 ;
        rollCount++;

        System.Console.Write("Roll " + rollCount + ": " + die1 + " and " + die2 + ", total " + total + ".");


        if (die1 == 1 && die2 == 1)
        {
            System.Console.WriteLine(" Snake eyes.");
        }
        else if ( die1 == die2)
        {
            System.Console.WriteLine( " Doubles!");
        }
        else if (total == 7 || total == 11)
        {
            System.Console.WriteLine(" A winner.");
            winCount++;
        }
        else
        {
        System.Console.WriteLine();
        }

         System.Console.Write("Roll again? (y/n): ");
        rollAgain = Console.ReadLine() ?? "" ;
        
    } while (rollAgain == "y") ;

    System.Console.WriteLine("You Rolled " + rollCount + " times and won " + winCount + ".");

}
if (choice == 3 || choice == 4)
{
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");

    int[] scores = new int [5] ;

    //A for loop is used because we need an index to enter five scores. 
    for (int i = 0; i < scores.Length; i++)
    {
        System.Console.Write("Score " + (i +1) + ": ");
        scores[i] = Convert.ToInt32(Console.ReadLine()) ;
    }

    int total = 0 ;
    int highest = scores[0] ; 
    int passing = 0 ;

    // A foreach loop is used because we need to examine every score
    foreach (int score in scores)
    {
        total += score;

        if (score > highest)
        {
            highest = score ;
        }
        if (score >= 60)
        {
            passing++;
        }
    }
    double average = Convert.ToDouble(total) / scores.Length;
    
    System.Console.WriteLine("Scores entered: " + scores.Length);
    System.Console.WriteLine("Total: " + total);
    System.Console.WriteLine("Average: " + average.ToString("F1"));
    System.Console.WriteLine("Highest: " + highest);
    System.Console.WriteLine("Passing: " + passing + " of " + scores.Length);

}


