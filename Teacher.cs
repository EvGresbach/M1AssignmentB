using System; 
namespace M1AssignmentB{
    public class Teacher : Person, Talkable  
    {
        private int _age; 
        public int age 
        {
            get{return _age;}
            set{_age = value;}
        }

        public Teacher(int age, string name) : base(name){
            _age = age;
        }
        public string Talk()
        {
            return "Don't forget to do the assigned reading!"; 
        }
        
    }
}
