using System;
using System.Collections;

namespace M1AssignmentB 
{
    internal class Program
    {
        private static FileOutput _outFile = new FileOutput("animals.txt"); 
        // private static FileInput _inFile = new FileInput("animals.txt");

        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList(); 

            UserAnimal userAnimal = new UserAnimal(zoo); 

            bool moreAnimals = false; 
            do
            {
                userAnimal.AddAnimal();
                Console.Write("Would you like to add an animal (Y/N)? \n>>"); 
                moreAnimals = Console.ReadLine().ToUpper() == "Y"; 
            }while(moreAnimals); 

            zoo = userAnimal.AnimalList; 

            foreach(Talkable thing in zoo)
            {
                PrintOut(thing); 
            }

            
            _outFile.FileClose(); 

            FileInput _inFile = new FileInput("animals.txt");
            _inFile.FileRead(); 
            _inFile.FileClose(); 

            FileInput inData = new FileInput("animals.txt"); 
            string line; 
            while((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line); 
            }
        }
         public static void PrintOut(Talkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk()); 
            _outFile.FileWrite(p.GetName() + " | " + p.Talk()); 
        } 
    }
}
