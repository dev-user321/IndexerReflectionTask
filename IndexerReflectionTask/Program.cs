using IndexerReflectionTask.Implementations;
using IndexerReflectionTask.Interface;
using IndexerReflectionTask.Models;
using System.Reflection;

namespace IndexerReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Reflection
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type.GetProperty("Id"));
            }
            #endregion

            #region Indexer 
            Person person1 = new Person()
            {
                Id = 1,
                Name = "Person 1",
                LastName = "LastName Person 1"
            };
            Person person2 = new Person()
            {
                Id = 2,
                Name = "Person 2",
                LastName = "LastName Person 2"
            };
            Person person3 = new Person()
            {
                Id = 3,
                Name = "Person 3",
                LastName = "LastName Person 3"
            };
            Person[] people1 = { person1, person2, person3 };

            People people2 = new People(people1);
            //people2.People1 = people1;

            Console.WriteLine(people2[2]);

            #endregion

            #region Task
            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Id = 1,
                Name = "Student 1",
                LastName = "LastName Student 1",
                UniversityName = "University for Student 1"
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Student 2",
                LastName = "LastName Student 2",
                UniversityName = "University for Student 2"
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Student 3",
                LastName = "LastName Student 3",
                UniversityName = "University for Student 3"
            };
            Student student4 = new Student()
            {
                Id = 4,
                Name = "Student 4",
                LastName = "LastName Student 4",
                UniversityName = "University for Student 4"
            };

            students.Add(student4);

            StudentImp studentImp = new StudentImp();
            studentImp.Add(student1);
            studentImp.Add(student2);
            studentImp.AddRange(students);
            studentImp.Clear(1);
            Console.WriteLine(studentImp.FindById(4));

            var result = studentImp.GetAll();
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            #endregion
        }
    }
}
