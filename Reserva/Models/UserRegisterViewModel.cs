using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz.")]
		public string Isim { get; set; }
		
		[Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
		public string Soyisim { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil.")]
		public string ConfirmPassword { get; set; }
	}
}
