using AppVkontakte.Models;
using System.ComponentModel.DataAnnotations;

namespace AppVkontakte.ViewModels
{
    public class UserEditViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Имя", Prompt = "Введите имя")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Фамилия", Prompt = "Введите фамилию")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "example.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата рождения", Prompt = "Дата")]
        public DateTime BirthDate { get; set; }

        
        [DataType(DataType.Text)]
        [Display(Name = "Ссылка", Prompt = "Ссылка на картинку")]
        public string Image { get; set; }

        
        [DataType(DataType.Text)]
        [Display(Name = "Статус", Prompt = "Введите свой статус")]
        public string Status { get; set; }

        
        [DataType(DataType.Text)]
        [Display(Name = "О себе", Prompt = "Введите информацию о себе")]
        public string About { get; set; }

        //public string UserName { get; set; }

        public string UserId { get; set; }

    }
}
