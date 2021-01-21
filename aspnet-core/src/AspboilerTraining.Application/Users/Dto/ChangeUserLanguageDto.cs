using System.ComponentModel.DataAnnotations;

namespace AspboilerTraining.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}