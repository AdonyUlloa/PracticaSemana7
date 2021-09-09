using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string fistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }

        //metodo  con la coleccion de datos
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent=1001, fistName="Jose", lastName="Robles", age=25, nationality="Salvadoreño"},
                new Student{idStudent=1002, fistName="Ana", lastName="Lopez", age=20, nationality= "Estadounidense"},
                new Student{idStudent=1003, fistName="Rafael", lastName="Gonzalez", age=21, nationality= "Costarricense"},
                new Student{idStudent=1004, fistName="Alfredo", lastName="Vayadares", age=23, nationality= "Guatemanteco"},
                new Student{idStudent=1005, fistName="Amanda", lastName="Flores", age=22, nationality= "Española"},
            };
            return students; //retornamos coleccion
        }
       
    }
}
