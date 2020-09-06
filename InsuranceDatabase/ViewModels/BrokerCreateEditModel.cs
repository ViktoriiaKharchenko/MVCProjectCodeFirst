using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceDatabase.ViewModels
{
    public class BrokerCreateEditModel
    {
        public int Id { get; set; }
        [Remote(action: "NameValid", controller: "Brokers")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }
        [Remote(action: "SurnameValid", controller: "Brokers")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Дата народження")]
        [DataType(DataType.Date)]
        [Remote(action: "DateValid", controller: "Brokers")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Remote(action: "PhoneValid", controller: "Brokers")]
        [Display(Name = "Телефон")]
        [StringLength(10, ErrorMessage = "Телефон занадто довгий")]
        public string PhoneNum { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        //[Remote(action: "PassportValid", controller: "Brokers", AdditionalFields = nameof(Id))]
        [Display(Name = "Номер паспорта")]
        [StringLength(9, ErrorMessage = "Телефон занадто довгий")]
        public string Passport { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [EmailAddress(ErrorMessage = "Невіриний формат данних")]
        [Display(Name = "Електронна пошта")]
        public string Email { get; set; }

        [Display(Name = "Фото")]
        public IFormFile Photo { get; set; }
    }
}
