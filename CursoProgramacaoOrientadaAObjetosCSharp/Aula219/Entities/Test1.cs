using System;namespace Aula219.Entities
{
    internal class Test1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Test1(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Test1)) return false;
            Test1 other = obj as Test1;
            return other.Id == Id && other.Name == Name;
        }
    }
}
