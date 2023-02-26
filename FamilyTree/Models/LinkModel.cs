using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Models
{
    public class LinkModel
    {
        [Required] 
        public int Id { get; set; }

        [Required]
        [ForeignKey("PeopleMain")]
        public int PeopleId { get; set; }

        [Required]
        public int PeopleChildID { get; set; }

        [Required]
        public int Level { get; set; }

        public PeopleModel PeopleMain { get; set; } = null!;
    }
}
