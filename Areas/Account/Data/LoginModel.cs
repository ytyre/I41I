using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using I41I.Models;


namespace I41I.Areas.Account.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Поле Логин обязательно для заполнения")]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения")]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
