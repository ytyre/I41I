using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using I41I.Models;


namespace I41I.Areas.Account.Data
{
	public class RegisterModel	
	{
		[Required(ErrorMessage = "Поле Логин обязательно для заполнения")]
        [DisplayName("Логин")]
		public string Login { get; set; }
		
		
		[Required(ErrorMessage = "Поле E-mail обязательно для заполнения")]
		[EmailAddress(ErrorMessage = "Введен некорректный адрес")]
		[DisplayName("E-mail")]
		public string Email { get; set; }
		
		[Required(ErrorMessage = "Поле Пароль обязательно для заполнения")]
		[DisplayName("Пароль")]
		public string Password { get; set; }
		
		
		[Required(ErrorMessage = "Поле Пароль ещё раз обязательно для заполнения")]
		[Compare("Password", ErrorMessage = "Пароли не совпадают")]
		[DisplayName("Пароль ещё раз")]
		public string ConfirmPassword { get; set; }

		public ApplicationUser GetUser()
		{
			ApplicationUser user = new()
			{
				Email = Email,
				UserName = Login,
			};
			return user;
		}
	}
}
