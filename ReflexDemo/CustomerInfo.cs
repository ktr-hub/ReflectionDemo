using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    public class CustomerInfo
    {
        public int ID;
        public string ClassName;
        public int Id
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }

        public CustomerInfo()
        {
            this.ID = -1;
            this.ClassName = "";
        }

        public CustomerInfo(int ID,string ClassName)
        {
            this.ID = ID;
            this.ClassName = ClassName;
        }

        public void PrintId()
        {
            Console.WriteLine("Id is: {0}", this.ID);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is: {0}", this.ClassName);
        }

    }
}
