﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyContacs.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "Klubb")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        [Display(Name = "Team")]
        public int? TeamId { get; set; }
        [Display(Name = "Team")]
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        [Display(Name = "Roll")]
        public int? RoleId { get; set; }
        [Display(Name = "Roll")]
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [Display(Name = "Sport")]
        public int? SportId { get; set; }
        [Display(Name = "Sport")]
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }

        [Display(Name = "Distrikt")]
        public int? DisrtictId { get; set; }
        [Display(Name = "Distrikt")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Förnamn")]
        public String FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public String LastName { get; set; }


        [Display(Name = "Namn")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }


        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }


        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "SSN#")]
        public string Ssn { get; set; }

    }
}
