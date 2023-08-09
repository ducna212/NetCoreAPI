using NewApp.Models;
public class Program
{
  public static void Main(string[] args)
  {   
    // Employee e1 =new Employee();
    // Employee e2 =new Employee();
    // Employee e = new Employee();
    // e1.Display();
    // string ten = "Nguyen Thi C";
    // int tuoi = 30;
    // e2.Display(ten,tuoi);
    // System.Console.WriteLine("{0} sinh nam {1}",ten,e.tinhnamsinh(tuoi));

    Employee[] empArray = new Employee[7];
    
    for (int i=0;i<2;i++)
    {
      System.Console.WriteLine("Nhap nhan vien thu {0}: ",i);
      Employee ep = new Employee();
      ep.Nhapthongtin();
      empArray[i] = ep;
    }

    foreach (Employee emp in empArray)
    {
      string fname = emp.Name;
      string address = emp.Add;
      int tuoi = emp.Age;
      System.Console.WriteLine("Ho ten: {0} - Dia chi: {1} - tuoi: {2}",fname,address,tuoi);
    }
  }
}