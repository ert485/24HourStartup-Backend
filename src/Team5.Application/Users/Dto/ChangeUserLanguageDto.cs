using System.ComponentModel.DataAnnotations;

namespace Team5.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}