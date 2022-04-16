using System.Collections; 
namespace M1AssignmentB
{
    public class UserAnimal
    {
        private ArrayList _animalList; 
        public ArrayList AnimalList 
        {
            get{return _animalList;}
        }

        public UserAnimal(ArrayList animalList)
        {
            _animalList = animalList; 
        }
        public void AddAnimal()
        {
            int animalType = GetAnimalType();

            switch(animalType)
            {
                case 1: 
                    _animalList.Add(GetDog());
                    break;
                case 2: 
                    _animalList.Add(GetCat()); 
                    break; 
                case 3:
                    _animalList.Add(GetTeacher()); 
                    break; 
            }
        }

        private int GetAnimalType()
        {
            int animalType = 0; 
            do
            {
                Console.Write("What animal would you like to create: \n1) Dog\n2) Cat\n3) Teacher\n>>"); 
                string input = Console.ReadLine();
                if(!Int32.TryParse(input, out animalType))
                {
                   Console.WriteLine("Invalid integer. Please enter an integer"); 
                }
                if(animalType < 1 || animalType > 3)
                {
                    Console.WriteLine("Invalid number. Please enter one of the choices listed"); 
                }
            }while(animalType != 1 && animalType != 2 && animalType != 3);
            return animalType; 
        }

        public Cat GetCat()
        {
            Console.Write("Enter the name: "); 
            string name = Console.ReadLine();
            int miceKilled = -1;
            do
            {
                Console.Write("Enter the number of mice killed: "); 
                
                string input = Console.ReadLine();
                if(!Int32.TryParse(input, out miceKilled))
                {
                   Console.WriteLine("Invalid integer. Please enter an integer"); 
                }
            }while(miceKilled < 0); 

            
            Console.WriteLine(miceKilled); 
            Cat cat = new Cat(miceKilled, name); 
            return cat; 
        }
        public Dog GetDog()
        {
            Console.Write("Enter the name: "); 
            string name = Console.ReadLine();
            Console.Write("Enter if it's nice (Y/N): "); 
            bool friendly = Console.ReadLine().ToUpper() == "Y"; 
            Dog dog = new Dog(friendly, name); 
            return dog; 
        }
        public Teacher GetTeacher()
        {
            int age = -1;
            do
            {
                Console.Write("Enter the age: "); 
                string input = Console.ReadLine();
                if(!Int32.TryParse(input, out age))
                {
                    Console.WriteLine("Invalid integer. Please enter an integer"); 
                }
            }while(age < 0);
            
            Console.Write("Enter the name: "); 
            string name = Console.ReadLine();

            Teacher teacher = new Teacher(age, name); 
            return teacher; 
        }

    }
}