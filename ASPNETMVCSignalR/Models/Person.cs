using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCSignalR.Models
{
    public class Person
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Укажите Имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Укажите Фамилию")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Укажите Отчество")]
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Укажите Дату рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        public DateTime Date { get; set; }


        [Display(Name = "Биография")]
        public string Bio { get; set; }

    }
}