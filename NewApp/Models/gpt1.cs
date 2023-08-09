namespace NewApp.Models
{
    public class GPT1
    {
        public double a { get; set;}
        public double b { get; set;}
        public void NhapDuLieu()
        {
            System.Console.Write("Nhap gia tri a = ");
            a = Convert.ToDouble(Console.ReadLine()) ;
            System.Console.Write("Nhap gia tri b = ");
            b = Convert.ToDouble(Console.ReadLine()) ;
        }
        public double TimNghiem(double a, double b)
        {
            double nghiem = -b/a;
            return nghiem;
        }
        public GPT1()
        {
            a = 3;
            b = -3;
        }
    }

}