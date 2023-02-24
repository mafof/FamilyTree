using System.ComponentModel.DataAnnotations;

namespace FamilyTree.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Заполните поле фамилия")]
        [Display(Name = "Фамилия")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Заполните поле имя")]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }
    }
}
