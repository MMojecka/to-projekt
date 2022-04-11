using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MemberInfo member = typeof(Student);
            //Student student = new Student("Jan", "Kowalski", "89000");
            //student.showInformation();

            // stworzenie instancji student
            var student = Activator.CreateInstance(typeof(Student));
            // dostęp do atrybutów klasy
            PropertyInfo[] properties = student.GetType().GetProperties();
            // set values
            PropertyInfo prep1  = properties[0];
            PropertyInfo prep2 = properties[1];
            PropertyInfo prep3 = properties[2];
            prep1.SetValue(student, "Jan");
            prep2.SetValue(student, "Kowalski");
            prep3.SetValue(student, "89000");

            Console.WriteLine("Imię: {0}, Nazwisko: {1}, Indeks: {2}", 
                prep1.GetValue(student, null), prep2.GetValue(student, null), prep3.GetValue(student, null));
            //konstruktory

            var defaultConstructor = typeof(Student).GetConstructor(new Type[0]); //type[0] oznacza pusty konstruktor
            var defaultConstructorTest = (Student)defaultConstructor.Invoke(null);
            Console.WriteLine("Konstruktor domyślny, wartości parametrów: {0}, {1}, {2}", defaultConstructorTest.Name, defaultConstructorTest.Surname, defaultConstructorTest.IndexNumber);

            var parameterConstructor = typeof(Student).GetConstructor(new[] { typeof(string), typeof(string), typeof(string)});
            var parameterConstructorTest = (Student)parameterConstructor.Invoke(new Object[] {"Kamil", "Ślimak", "12345"});
            Console.WriteLine("Konstruktor z parametrami, wartości parametrów: {0}, {1}, {2}", parameterConstructorTest.Name, parameterConstructorTest.Surname, parameterConstructorTest.IndexNumber);
            //metody
            var TestMethod = typeof(Student).GetMethod("showInformation");
            var invoker = (Student)TestMethod.Invoke(student, new object[] { });






            Console.ReadKey();
        }
    }
}
