namespace M1AssignmentB
{
    public abstract class Person{
        private string _name; 
        public string Name 
        {
            get{return _name;} 
            set{_name = value;}
        }
        public Person(string name) => _name = name;
        public string GetName()
        {
            return Name;
        }
    }
}