namespace CatWorx.BadgeMaker
{
    class Employee
    {
        //by default properties and methods defined in a class may only be used in that class. you can add an access modifier to make them accessible in other areas -- hence the word public
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;
        
        //creates a constructor that takes the employees first and last name and sets it to input used in Program.cs
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }
        
        //combines the first and last name from the input into one
        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}