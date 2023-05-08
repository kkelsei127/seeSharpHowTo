// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections.Generic;
//here we import a common namespace called ~"System"~
//"using" is similar to import or require

//the "System" namespace is part of the .Net framework:
    //it is a collection of commonly used methods, data types, and data structures


namespace CatWorx.BadgeMaker
//namespaces are used to organize and provide a level of separation in the code, 
//similar to a node.js
    //namespaces are containers that have members. A member can be another nested namespace, a method, 
    //or a class(like below)
        //everything inside the curlies can be interpreted as members of the CatWorx namespace

//common C# conventions are to use a company name for the root namespace in order to ensure it is unique!
{
    class Program
    {
        static void Main(string[] args)
        //the "Main" method:
            //this serves as the entry point of the application and is invoked when the program runs
            //in order for Main to be recognized as thee programs entry point, we must use the following syntax:
                //"Main" must be nested in a class
                //There can only be ONE entry point to a program
                //the keyword "void" represents that the return of the executable method will be void
                //the keyword "static" implies that the scope of this method is at the CLASS level, not object
                    //and can be invoked without having to create a new class instance. Which is why Main()
                    //can run as soon as the program runs
        
        //we use the following syntax to initialize the Main() method with, or without parameters:
                            //static void Main() - entry point
            //alternatively you can initialize it as on line 22*
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~Strings!!!~~~~~~~~~~~~~~~~~~");
            string greeting = "Hello";
            greeting = greeting + "Cattios";
            Console.WriteLine("Greeting: " + greeting);

            //string interpolation can be used with the following examples:
            Console.WriteLine($"greeting: {greeting}"); 
            Console.WriteLine("greeting: {0}", greeting);
            Console.WriteLine("Hello and Welcome to CatWorx, all things needed for Cattios!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~Integers!~~~~~~~~~~~~~~~~~~~");

            float side = 3.14F;
            //when you write a decimal with no suffix it is default type "double", if you want to convert
            //the literal to a float we must include the "F" suffix as above

            float area = side * side;

            Console.WriteLine("Did we do it? " + area);

            //or we can change the type to double
            double smallSide = 3.14;
            double smallArea = smallSide * smallSide;

            Console.WriteLine("Did we do it? PT 2: " + smallArea);

            int num = 10;
            num += 100;
            //returns 110

            num ++;
            //returns 111
            Console.WriteLine(num);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~Booleans!~~~~~~~~~~~~~~~~~~~");

            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~DATA CONVERSIONS!~~~~~~~~~~~~~~~~");

            string stringNum = "2";
            int intNum = Convert.ToInt32(stringNum);
            //Int32 designates the storage available for the variable

            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~DATA STRUCTURES: DICTIONARIES!~~~~~~~~~~~~");

            //Similar to object literals in JavaScript, dictionaries in C# use a key-value pair relationship
                //Data types for a dictionary's key-value pair types are declared in angled brackets
            
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

            //To populate the dictionary, we use the Add() method in multiple lines to add data
            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);
            myScoreBoard.Add("fourthInning", 40);
            myScoreBoard.Add("fifthInning", 50);


            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard 1");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            //Alternatively, we could initialize the dictionary by listing the key-value pairs in a function call
            Dictionary<string, int> theScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 10 },
                { "secondInning", 20},
                { "thirdInning", 30},
                { "fourthInning", 40},
                { "fifthInning", 50}
            };

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard 2");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", theScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", theScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", theScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", theScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", theScoreBoard["fifthInning"]);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~DATA STRUCTURES: ARRAYS!~~~~~~~~~~~~~~~");


            //there are a couple of distinctions in the way C# handles arrays, because the data type 
            //of the array’s elements must be declared.
                //Another distinction is that the length of the array must also be set when the array is declared. 
                                //~No new elements can be added or subtracted from the array.~!!!!

            string[] favFoods = new string[3]{ "pizza", "salads", "pasta" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~DATA STRUCTURES: LISTS!~~~~~~~~~~~~~~~");

            List<string> employees = new List<string>() { "adam", "kelsei" };

            employees.Add("ricardo");
            employees.Add("richard");

            Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~LOOPS!~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < employees.Count; i++) 
            {
            Console.WriteLine(employees[i]);
            }
        }
    }
}