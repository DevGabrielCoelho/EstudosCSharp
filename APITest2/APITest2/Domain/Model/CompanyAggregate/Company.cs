using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITest2.Domain.Model.CompanyAggregate
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Company()
        {
        }

        public Company(int id, string? name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
