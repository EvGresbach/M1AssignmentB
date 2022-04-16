using System; 
namespace M1AssignmentB{
    public class Cat : Pet, Talkable  
    {
        private int _mousesKilled; 
        public int MousesKilled
        {
            get{return _mousesKilled;}
        }

        public Cat(int mousesKilled, string name) : base(name){
            _mousesKilled = mousesKilled;
        }

        public void addMouse() 
        {
            _mousesKilled++;
        }

        public string Talk()
        {
            return "Meow"; 
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Cat: name=" + Name + " mousesKilled=" + _mousesKilled; 
        }
    }
}
