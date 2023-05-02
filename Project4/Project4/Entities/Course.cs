namespace Project4.Entities
{
    class Course
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public List<Student> Students { get; private set; }

        public Course(int code, string name)
        {
            Code = code;
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if(student != null)
            {
                Students.Add(student);
                
            }
        }
    }
}
