using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Models
{
    [Keyless]
    public class GrandMotherGreatGrandsonModel
    {
        public int IdGrandmother { get; set; }
        public int IdGreatGrandson { get; set; }
        public string FullnameGrandmother { get; set; } = null!;
        public string FullnameGreatGrandson { get; set; } = null!;
    }
}
