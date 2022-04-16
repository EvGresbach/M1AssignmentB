using System; 
namespace M1AssignmentB{
    public class Dog : Pet, Talkable  
    {
        private bool _friendly; 
        public bool Friendly 
        {
            get{return _friendly;}
        }

        public Dog(bool friendly, string name) : base(name){
            _friendly = friendly;
        }
        public string Talk()
        {
            return "Bark"; 
        }
        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return "Dog: name=" + Name + " friendly=" + _friendly; 
        }
    }
}
