using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            Notebook notebook = new Notebook("see", "create", "remove");

            // keyword to exit the program
            const string ExitProgramKeyword = "exit";

            // notebook.show  and co are readonly variables that call specific functions
            // this is the output that will be shown when there is a keynotfoundexception
            // it hints the user the correct keywords to ente eh show, delete or new
            string commandPrompt = "please enter " + notebook.show + ", " + notebook.delete + ", or " + notebook._new;
            // display intro message before user makes any input
            Console.WriteLine(Notebook.IntroMessage);
            // IntroMessage is a const/static and is accessed using the Class name - Notebook- rather than instance name - notebook

            // loop through user input
            string input = "";
            do
            {
                // accept user input
                input = Console.ReadLine();
                string[] commands = input.Split();//convert user input to array of words
                // get the first command...show, new or delete
                // and pass the second to the function

                // use try catch bkock to handle keynotfoundexception
                try
                {
                    notebook[commands[0]]((commands.Length > 1) ? commands[1] : "");
                } catch (KeyNotFoundException)
                {
                    Console.WriteLine(commandPrompt);
                }
               
                
            } while (input != ExitProgramKeyword);

            Console.WriteLine(Notebook.OutroMessage);

        }
	}
}
