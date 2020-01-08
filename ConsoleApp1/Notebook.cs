using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Notebook
    {
        // intro and outro message
        public const string IntroMessage = "Welcome";
        public const string OutroMessage = "Goodbye";
        // 
        // the notebook has list of pages attribute

        public delegate void SimpleFunction(string command);// delegates are like a variable for functions
        //if we have a variable of this type of delegate, the function types =it can take are the one that return nothing and have one 
        // argument of type string
        // dictionary works like hashmap, associates a key (the string) to a value (the function SimpleFunction)
        private Dictionary<string, SimpleFunction> commandLineArgs = new Dictionary<string, SimpleFunction>(); 

        // defind readonly variables. these are keywords associated with our disfferent functions
        public readonly string show = "show", _new = "new", delete = "delete"; // when we say show, call the show function and so on

        // create indexer, indexe helps to access the dictionary easilty from our program
        // when using our indexer, we'll be passing in a string
        public SimpleFunction this[string command] 
        {
            get { return commandLineArgs[command]; }
        }

        // first Notebook constructor - so we can initialise the dictionary
        public Notebook()
        {
            //associate show with Show method using the dictionary's Add method
            commandLineArgs.Add(show, Show);// means, when we use the show keyword, execute the Show method
            commandLineArgs.Add(_new, New);
            commandLineArgs.Add(delete, Delete);
        }
        // second Notebook contstructor -- calls the base constructor first using this
        // params keywords means we'll specify as many strings as we want 
        // commandLineKeywords is an arrray
        public Notebook(params string[] commandLineKeywords) : this()
            // this() with no argument means, use this class's constructor with no argument before executing this constructor
        {
            for(int i = 0; i < commandLineKeywords.Length; ++i)
            {
                // if nothing is input, jump to next iteration
                if(commandLineKeywords[i] == "")
                {
                    continue;
                }

                switch (i)
                {
                    // when their is an imput - the first word specified
                    // show
                    case 0:
                        commandLineArgs.Remove(show);// remove show from our dictionary
                        commandLineArgs.Add(show = commandLineKeywords[i], Show);// set show to that input and associate it with Show method
                        break;
                    // new
                    case 1:
                        commandLineArgs.Remove(_new);
                        commandLineArgs.Add(_new = commandLineKeywords[i], New);
                        break;
                    //delete
                    case 2:
                        commandLineArgs.Remove(delete);
                        commandLineArgs.Add(delete = commandLineKeywords[i], Delete);
                        break;
                }
            }
        }
        // we use the List class (dynamic array), contains the type of things to be held in our list
        List<IPageable> pages = new List<IPageable>();
        // above means the notebook will contains things of the type IPageable - textualmessage, messagelist and image
        // these 3 textualmessage, messagelist and image will be inside the List
        // this class does the following
        // 1. show all pages 
        // 2 create new pages such as textual message, messagelist and image
        // 3 delete pages

        // method to show pages
        public void Show(string command)
        {
            Console.WriteLine("Show method" + command);
        }
       

        // create new pages
        public void New(string command)
        {
            Console.WriteLine("New method" + command);
        }

        // delete pages
        public void Delete(string command)
        {
            Console.WriteLine("Delete method" + command);
        }

    }
}
