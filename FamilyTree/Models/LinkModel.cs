using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Models
{
    public class LinkModel
    {
        [Required]
        public int Id { get; set; }

        [ForeignKey("PeopleMain")]
        public int? PeopleId { get; set; }

        [ForeignKey("PeopleChildren")]
        public int? PeopleChildID { get; set; }

        [Required]
        public int Level { get; set; }

        [InverseProperty("LinksMain")]
        public PeopleModel PeopleMain { get; set; } = null!;

        [InverseProperty("LinksChildren")]
        public PeopleModel PeopleChildren { get; set; } = null!;
    }
}
