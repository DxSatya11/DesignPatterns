using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignParten
{
    public class Student
    {

        //Eager Way to create objecy of class single tine in singleton design parten
        private static Student? student = new Student();

        private Student() { }   
        
        public static Student getStudent()
        {
            return student;
        }
    }
}
