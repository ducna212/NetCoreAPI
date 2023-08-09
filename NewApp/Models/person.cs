namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Adress  { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Adress: ");
            Adress = Console.ReadLine();
            System.Console.Write("Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName,Adress, Age);
        }

        public void Display(string ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
        }
        public Person()
        {
            FullName = "Ho ten mac dinh";
            Adress = "Dia Chi mac dinh";
            Age = 20; //Tuoi mac dinh =20
        }
        public int YearOfBirth(int age)
        {
            int YearOfBirth = 2023 - age;
            return YearOfBirth;
        }
    }
}