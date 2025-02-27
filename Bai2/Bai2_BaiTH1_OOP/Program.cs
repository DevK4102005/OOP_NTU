using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Calculator
{
      class Program
      {
            static void Main()
            {
                  int a,b;
                  char ch;
                  double ketQua=0;

                  //Input: Khong thay doi phan nay
                  Console.Write("Nhap a = ");
                  //Chuyen doi so nhap vao tu ban phim tu kieu chuoi thanh kieu so nguyen
                  a=int.Parse(Console.ReadLine());
                  Console.Write("Nhap b = ");
                  b=int.Parse(Console.ReadLine());
                  Console.Write("Nhap phep toan (+,-,*,/): ");
                  ch=char.Parse(Console.ReadLine());

                  /*
                    Viet doan code xu li cua ban o day
                    Dua vao a,b va phep toan nhap vao hay tinh gia tri va in ra gia tri bieu thuc len man hinh
                  */
                  if(ch=='+')
                  {
                        Console.Write("{0} + {1} = {2}",a,b,a+b);
                  }
                  else if(ch=='-')
                  {
                        Console.Write("{0} - {1} = {2}",a,b,a-b);
                  }
                  else if(ch=='*')
                  {
                        Console.Write("{0} * {1} = {2}",a,b,a*b);
                  }
                  else
                   {
                        while(b==0)
                        {
                              Console.WriteLine("Hay nhap lai b khac 0!");
                              Console.Write("Nhap b =");
                              b=int.Parse(Console.ReadLine());
                        }
                        Console.Write("{0} / {1} = {2}",a,b,a/b);
                   }
            }
      }
}
