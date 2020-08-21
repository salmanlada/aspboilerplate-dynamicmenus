using System.ComponentModel.DataAnnotations;

namespace MyApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}