using Project4.Entities;

namespace Project4
{
    class Program
    {
        static HashSet<Student> allStudents = new HashSet<Student>();

        static void Main(string[] args)
        {
            // Searches CourseData directory path which contains the single file (courses.txt)
            string path = Directory.GetFiles(@"..\..\..\CoursesData\")[0];

            List<Course> courses = new List<Course>();

            /*
              Reads each line from courses.txt, gets course's code and name and puts them inside a
              course instance.
              Finally, each course is added to a list.
             */
            try
            {
                Course course;
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split('-');
                        int code = int.Parse(line[0].Trim());
                        string name = line[1].Trim();
                        course = new Course(code, name);
                        courses.Add(course);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

            // Adds students to each course and also to a hashSet containing all students.
            AddStudents(courses);

            // Shows the total number of distincted students.
            Console.WriteLine();
            Console.WriteLine("Total students: " + allStudents.Count);
        }

        static void AddStudents(List<Course> list)
        {

            foreach (Course course in list)
            {
                Console.WriteLine();
                Console.Write("How many students for " + course.Name + " course? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Enter id student: ");
                    int id = int.Parse(Console.ReadLine());
               
                    Student s = new Student(id);
                    course.AddStudent(s);
                    allStudents.Add(s);
                }   
            }
        }
    }
}