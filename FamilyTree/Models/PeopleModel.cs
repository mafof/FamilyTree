using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Models
{
    public class PeopleModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Surname { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public string? Patronymic { get; set; }

        public ICollection<LinkModel> Links { get; set; } = null!;
    }
}
