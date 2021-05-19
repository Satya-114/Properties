using System;

namespace Read_and_write_only_properties
{
   public class example
    {
        int num1, num2, result;
        public int setnum1
        {
            set
            {
                num1 = value;
            }
        }
        public int setnum2
        {
            set
            {
                num2 = value;
            }
        }
        public int getresult
        {
            get
            {
                return result;
            }
        }
        public void add()
        {
            result = num1 + num2;
        }
        public void sub()
        {
            result = num1 - num2;
        }
        public void mul()
        {
            result = num1 * num2;
        }
        public void div()
        {
            result = num1 / num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            example obj1 = new example();
            Console.WriteLine("ENTER ANY TWO NUMBERS");
            obj1.setnum1 = int.Parse(Console.ReadLine());
            obj1.setnum2 = int.Parse(Console.ReadLine());
            obj1.add();
            Console.WriteLine("the sum is:" + obj1.getresult);
            obj1.sub();
            Console.WriteLine("the sub is:" + obj1.getresult);
            obj1.mul();
            Console.WriteLine("the mul is:" + obj1.getresult);
            obj1.div();
            Console.WriteLine("the div is:" + obj1.getresult);
            Console.ReadKey();
        }
    }
}   
   

