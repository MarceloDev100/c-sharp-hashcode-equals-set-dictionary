namespace Project4.Entities
{
    class Student
    {
        public int Id { get; private set; }
       
        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;
            return Id.Equals(other.Id);
        }
    }
}
