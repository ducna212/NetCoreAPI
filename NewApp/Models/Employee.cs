namespace NewApp.Models
{
    public class Employee
    {
        public string Name { get; set;}
        public string Add { get; set;}
        public int Age { get; set;}

        // public Employee()
        // {
        //     Name = "Ho ten mac dinh";
        //     Add = "Dia chi mac dinh";
        //     Age = 25;
        // }
        public void Nhapthongtin()
        {
            System.Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();
            System.Console.Write("Nhap dia chi: ");
            Add = Console.ReadLine();
            System.Console.Write("Nhap tuoi: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display(string Name, int Age)
        {
            System.Console.WriteLine("Nhan vien: {0}  - Tuoi : {1}",Name,Age);
        }
        public void Display()
        {
            System.Console.WriteLine("Nhan vien: {0} - Dia chi: {1} - Tuoi : {2}",Name,Add,Age);
        }

        public int tinhnamsinh(int tuoi)
        {
            int namsinh = DateTime.Now.Year - tuoi;
            return namsinh;
        }

    }
}