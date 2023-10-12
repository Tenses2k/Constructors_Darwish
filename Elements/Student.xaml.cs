﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Constructors_Darwish.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student(Classes.Student student)  //тут поменял public на private
        {
            InitializeComponent();
            tb_fio.Content = student.GetFIO();
            tb_scholarship.Content = student.Scholarship ? "Степендия: получает" : "Степендия: не получает";
            tb_course.Content = $"Курс: { student.Course}";
        }
    }
}
