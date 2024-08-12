
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

string[] names = new string[]
{
    "Justin Jones",
    "DeAngelo Robinson",
    "Martina Basquez",
    "Alain Rene",
    "David Goodwin",
    "Joey Molinski",
    "Wren Grasley",
    "Brady Hartman",
    "David Brameijer",
    "Afseen Salam",
    "Ethan Thomas"
};

string[] hometowns = new string[]
{
    "Westerville",
    "Detroit",
    "Edinburg",
    "Homestead",
    "Jersey City",
    "Toledo",
    "Richmond",
    "Saranac",
    "Grand Rapids",
    "India",
    "Bolivar"
};

string[] favoriteFoods = new string[]
{
    "Baja Blast",
    "Pizza",
    "Leftovers",
    "Chicken Wings",
    "Sushi",
    "Dill Pickles",
    "Pizza",
    "Chicken Wings",
    "Tacos",
    "Shawarma",
    "Grapes"
};


/*
Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.
v
What will the application do?
2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. 
Use the integer as the index for the arrays. Print the student’s name.
1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
1 Point: Ask the user if they would like to learn about another student.


Build Specifications:
1 Point: Validate user number: Use an if statement to check if the number is out of range, i.e.
either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.
1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food".
Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, 
display a friendly message and re-ask the question. (See hints below!)
1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.



*/

bool runProgram = true;
int userInput = 0;
string userString;
bool validation = true;



Console.WriteLine("Welcome to the Grand Circus Student Database");
    for (int i = 0; i < names.GetLength(0); i++)
    {

        Console.WriteLine($"{i + 1}. {names[i]}");
    }



while (runProgram)
{
    while (validation)
    {
        Console.WriteLine("Would you like to search by name y/n?");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            Console.WriteLine("Please enter the name of the student.");
            userString = Console.ReadLine();
            for (int i = 0; i < names.GetLength(0); i++)
            {
                if (names[i] == userString)
                {
                    userInput = i + 1;
                    break;

                }
                else
                {
                    continue;
                }
            }

            if (names.Contains(userString) == false)
            {


                Console.WriteLine("There is no student by that name. Try Again");
            }

            else
            {
                break;
            }

        }




        else
        {
            do
            {
                Console.WriteLine($"Please select a number between: 1 and {names.Length}");
                userInput = int.Parse(Console.ReadLine());
                TooBigOrTooSmall(userInput, names);
                validation = false;
            }
            while (userInput <= 0 || userInput > names.Length);
        }

    }
    


    int index = userInput - 1;

    Console.WriteLine($"The chosen student's name is: {names[index]}");
    Console.WriteLine("Type \"food\" for their fav food.\nType \"home\" for their hometown.\nType \"students\" for a list of all the students");
    string userChoice = Console.ReadLine().ToLower();


    if (userChoice == "food")
    {
        Console.WriteLine($"Their favorite food is: {favoriteFoods[index]}");

    }
    else if (userChoice == "home")
    {
        Console.WriteLine($"Their hometown is: {hometowns[index]}");
    }
    else if (userChoice == "students")
    {
        for (int i = 0; i < names.GetLength(0); i++)
        {
            
            Console.WriteLine($"{i+1}. {names[i]}");
        }

    }
    else
    {
        Console.WriteLine("Try Again");
    }

    Console.WriteLine("Would you like to learn about another student y/n?");
    string restart = Console.ReadLine().ToLower();
    if (restart == "y")
    {
       
       
        validation = true;
       
    }
    else
    {
        Console.WriteLine("Thank you have a great day!");
        break;
    }
}


static void TooBigOrTooSmall(int num, string[] names)
{
    if (num <= 0)
    {
        Console.WriteLine("The number is too small, Try Again");
    }
    else if (num > names.Length) 
    {
        Console.WriteLine("The number is too big, Try Again");
    }
    else
    {

    }
}