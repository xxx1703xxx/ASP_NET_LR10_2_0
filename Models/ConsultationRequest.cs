using System;
using System.ComponentModel.DataAnnotations;
namespace LR10.Models
{
    public class ConsultationRequest
    {
        [Required(ErrorMessage = "Ім'я та прізвище є обов'язковими.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email є обов'язковим.")]
        [EmailAddress(ErrorMessage = "Невірний формат Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажіть бажану дату консультації.")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Дата повинна бути у майбутньому.")]
        [NoWeekends(ErrorMessage = "Дата не може потрапляти на вихідні.")]
        public DateTime PreferredDate { get; set; }

        [Required(ErrorMessage = "Оберіть продукт для консультації.")]
        public string Product { get; set; }
    }
}
