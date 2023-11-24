using System;

public class Program
{
    static void Main(string[] args)
    {
        //Word List Array
        string[] wordList = { "elbow", "ankle", "wrist", "knees", "thigh", "aster", "lilac", "peony", "chair", "piano", "table", "class", "grass", "lupin", "tulip", "viola", "voila", "swede", "onion", "chump", "punch", "twice", "nippy", "fizzy", "rhyme", "eight", "seven", "fifth", "chalk", "board" };

        //System that will allow you to pick a random number from the array
        Random numberGen = new Random();

        int random = 0;

        int tries = 5;
        {
            //Picks a random word from the array
            for(int i = 0; i < 1; i++)
            {
                random = numberGen.Next(0, 30);
            }

            //This is where the program has chosen a word from the array and is ready for the user to start guessing
            string chosenWord = (wordList[random]);
            while (tries > 0)
            {


                Console.WriteLine("Enter your 5 letter guess (all lowercase)");


                //Sets the default colour to white
                Console.ForegroundColor = ConsoleColor.White;

                //this takes what the user has inputted and assigns it to 'guess'
                string guess = Convert.ToString(Console.ReadLine());

                //this will allow the program to check each individual letter of the chosen word and compare it to the guessed word
                char a = chosenWord[0];
                char b = chosenWord[1];
                char c = chosenWord[2];
                char d = chosenWord[3];
                char e = chosenWord[4];

                char aa = guess[0];
                char bb = guess[1];
                char cc = guess[2];
                char dd = guess[3];
                char ee = guess[4];

                //If the guessed letter is the same as the letter from the chosen word, the background is highlighted green
                if (a == aa)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Displays to the console
                    Console.WriteLine(aa);
                }
                //If the guessed letter is in the wrong possition, it turns orange
                else if (b == aa)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(aa);
                }
                else if (c == aa)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(aa);
                }
                else if (d == aa)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(aa);
                }
                else if (e == aa)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(aa);
                }
                //If the guessed letter is not the same as the letter from the chosen word, the background is highlighted red
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(aa);
                }

                if (b == bb)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bb);
                }
                else if (a == bb)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(bb);
                }
                else if (c == bb)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(bb);
                }
                else if (d == bb)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(bb);
                }
                else if (e == bb)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(bb);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(bb);
                }

                if (c == cc)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(cc);
                }
                else if (a == cc)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(cc);
                }
                else if (b == cc)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(cc);
                }
                else if (d == cc)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(cc);
                }
                else if (e == cc)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(cc);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(cc);
                }

                if (d == dd)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(dd);
                }
                else if (a == dd)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(dd);
                }
                else if (b == dd)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(dd);
                }
                else if (c == dd)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(dd);
                }
                else if (e == dd)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(dd);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(dd);
                }

                if (e == ee)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ee);
                    //Add a space
                    Console.WriteLine("");
                }
                else if (a == ee)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ee);
                }
                else if (b == ee)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ee);
                }
                else if (c == ee)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ee);
                }
                else if (d == ee)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ee);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ee);
                    Console.WriteLine("");
                }

                //check for a win
                if (guess == chosenWord)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Press any key to restart...");
                    Console.ReadLine(); // Waits for user input
                }
                else
                {
                    tries--;
                }
                if (tries == 0)
                {
                    Console.WriteLine("Out of tries, the word was " + chosenWord);
                    Console.WriteLine("Press any key to restart...");
                    Console.ReadLine(); // Waits for user input
                }
               
                   
                
            }



        }

    }
}