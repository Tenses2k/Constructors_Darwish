using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Darwish.Classes
{
    class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Болтов", "Валерий", "Болтикович"));
            allStudent.Add(new Student("Заказов", "Расул", " "));
            allStudent.Add(new Student("Перемогов", "Рахмат", " ", true, 4));
            allStudent.Add(new Student("Хабибов", "Вадим", "Олегович", false, 2));
            allStudent.Add(new Student("Зуев", "Андрей", "Александрович", true, 1));
            return allStudent;
        }
    }
}
