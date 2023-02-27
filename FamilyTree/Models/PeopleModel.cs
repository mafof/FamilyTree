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

        [Required]
        public string Gender { get; set; } = null!;

        public List<LinkModel> LinksMain { get; set; } = new List<LinkModel>();

        public List<LinkModel> LinksChildren { get; set; } = new List<LinkModel>();
    }
}
