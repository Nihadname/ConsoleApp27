namespace ConsoleApp27.Domain.Models
{
    public class Student
    {
        private static int _idl;
        public int Id { get; set; }
        public string Name { get; set; }    
       public string SurName { get; set; }
        public int Age { get; set;}
        public Student(string name,string surName) {
            _idl++;
            Id=_idl;
            Name=name;
            SurName=surName;
        
        }

        public Student()
        {
            
        }

    }
}
