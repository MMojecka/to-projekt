using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IndexNumber { get; set; }

        public Student ()
        {

        }

        public Student(string name, string surname, string index)
        {
            this.Name = name; this.Surname = surname; this.IndexNumber = index;
        }

        public void showInformation()
        {
            Console.WriteLine("Metoda wyświetlająca. Imię: {0}, Nazwisko: {1}, Numer indeksu: {2}", this.Name, this.Surname, this.IndexNumber);
        }

        
        



    }
}
