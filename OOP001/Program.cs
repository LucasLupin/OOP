namespace OOP001
{
    static class Program
    {
        public static object? dateOfBirth { get; private set; }

        public static void Main(string[] args)
        {

           /* MyFirstClass myFirstObject = new MyFirstClass();
            // myFirstObject.str = "Some text";
            myFirstObject.Mymethod(); */

            Person myPerson = new Person();
            myPerson.Name = "Heino";

            myPerson.DoB = new DateTime(2000, 1, 1);
            Console.WriteLine(myPerson.AgeCalculator() );
            myPerson.DoB = new DateTime(2000, 12, 1);
            Console.WriteLine(myPerson.AgeCalculator());

        }
       
    }
}