﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Darwish.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Scholarship = false;
        public int Course = 4;

        //конструктор принимает фио
        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }


        //конструктор принимает фио степендию
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship)
            : this(Firstname, Lastname, Surname)
        {
            this.Scholarship = Scholarship;
        }



       
        //конструктор принимает фио степендию и курс
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course)
            : this(Firstname, Lastname, Surname, Scholarship)
        {
            this.Course = Course;
        }


        //метод который возвращает склеенное фио
        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}
