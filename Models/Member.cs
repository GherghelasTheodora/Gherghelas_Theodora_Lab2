﻿using System.ComponentModel.DataAnnotations;

namespace Gherghelas_Theodora_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu o majuscula ( ex:Ana)")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Prenumele trebuie sa aiba intre 3 si 30 caractere")]

        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage="Numele trebuie sa inceapa cu o majuscula")]
        [StringLength (30, MinimumLength =3, ErrorMessage = "Numele trebuie sa aiba intre 3 si 30 caractere")]
        public string? LastName { get; set; }

        [StringLength(70)]
        public string? Adress { get; set; }

        public string? Email { get; set; }

        [RegularExpression(@"^[0]+\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0711.123.123' sau '0722 123 123'")]

        public string? Phone { get; set; }

        [Display(Name = "FullName")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
