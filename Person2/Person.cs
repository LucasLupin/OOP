namespace OOP003
{
    internal class Person
    {
        //Private fields, that contain the data/values
        private string? name;
        private DateTime? dob;
        private string? email;
        private string? password;

        //Public properties that gets (return field) and sets (from value) the datavalues of our private fields.
        public string? Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Prøv igen...");
                    name = null;
                }
                else name = value;
            }
        }
        public DateTime? DoB
        {
            get { return dob; }
            set
            {
                if (value < DateTime.Now) dob = value;
                else
                {
                    Console.WriteLine("Fødselsdato ikke godkendt, skal være før i dag.");
                    dob = null;
                }
            }
        }
        public string? Email
        {
            get { return email; }
            set
            {
                if (value != null && value.Contains("@") && value.Contains(".")) email = value;
                else Console.WriteLine("Email skal indeholde @ og .");
            }
        }
        public string? Password
        {
            get { return password; }
            set
            {
                if (value != null && value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) password = value;
                else Console.WriteLine("Password skal være længere end 6 karakterer og indeholde store og små bogstaver samt tal");
            }
        }
        public int Age
        {
            get
            {
                if (DoB != null)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - ((DateTime)DoB).Year;
                    if (today < new DateTime(today.Year, ((DateTime)DoB).Month, ((DateTime)DoB).Day)) age--;
                    return age;
                }
                else return 0;

            }
        }

        //Auto implemented property
        public string? Description { get; set; }
    }
}