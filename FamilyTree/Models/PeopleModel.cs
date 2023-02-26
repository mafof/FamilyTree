using System.ComponentModel.DataAnnotations;

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

        public ICollection<LinkModel> LinksMain { get; set; } = null!;

        public ICollection<LinkModel> LinksChildren { get; set; } = null!;
    }
}
