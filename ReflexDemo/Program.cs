using System;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerInfo customerInfo = new CustomerInfo();
            //customerInfo.set_Name("Hell");

            ReflectionOnCustomer reflectionOnCustomer = new ReflectionOnCustomer();
            reflectionOnCustomer.ReflectionTest();
        }
    }
}
