using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITest2.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Photo { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int age, string photo)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Photo = photo;
        }
    }
}
