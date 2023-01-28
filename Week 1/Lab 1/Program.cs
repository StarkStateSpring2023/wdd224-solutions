/*****************************************************************
*** Gillis
*** WDD224 - Lab 1 C# Primer
*** 01/2023
*** Refresher on Basic C# Syntax
** Console will print hello world via loop, and then prompt for user age
*****************************************************************/

int iterattionCount = 10;

//I choose to do for loop here, you could also implment via while loop
//
for(int i = 0; i < iterattionCount; i++){
    Console.WriteLine("Hello World");
}

//WHILE LOOP if you would prefer that
// int count =0;
// while(count < iterattionCount){
//     count++;
//     Console.WriteLine("Hello World");
// }


//Now lets move on to the prompt for user age
    //I added some extra code in, to make testing easier
    //By adding an extra While loop, now we can continue prompting until the user decides they are done
string exitCode = "";
while(exitCode != "N"){
    Console.Write("What is your age? ");

    int userAge = int.Parse(Console.ReadLine());

    if(userAge < 18){
        Console.WriteLine("You are a child!");
    }else{
        Console.WriteLine("You are an Adult");
    }

    Console.Write("Would you like to Continue? Enter Y or N ");
     exitCode = Console.ReadLine().ToUpper();
}


//The only thing this is missing, is an extra layer of protection to ensure that the user only enters a valid number when prompted for their age not something like "DOG".
    //If you got this far, for 5 bonus points, add that extra layer of protection to my code, with an explantiation of how it works, and what you chose to do
    // and submit it to the dropbox on Blackboard.