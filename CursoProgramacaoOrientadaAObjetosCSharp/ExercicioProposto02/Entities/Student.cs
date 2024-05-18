namespace Entities
{
    internal class Student
    {
        public int Registration { get; private set; }

        public Student(int registration)
        {
            Registration = registration;
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Student)) return false;
            Student other = obj as Student;
            return Registration == other.Registration;
        }
        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }
    }
}
