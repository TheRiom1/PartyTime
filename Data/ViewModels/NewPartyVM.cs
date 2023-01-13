﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Data.Base;
using WebApplication3.Data.Enums;


namespace WebApplication3.Models
{
    public class NewPartyVM
    {
        public int Id{ get; set; }

        [Display(Name = "Logo")]
        public string Picture { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Display(Name = "Data rozpoczęcia")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Data zakończenia")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Cena")]
        public double Price { get; set; }
        [Display(Name = "Ilość gości")]
        public int Guests { get; set; }
        [Display(Name = "Dodatkowe dekoracje")]
        public AdditionalCost AdditionalCost { get; set; }
        //Relationship
        [Display(Name = "Opcje dodatkowe")]
        public List<int> FeatureIds { get; set; }
        [Display(Name = "Sala")]

        public int RoomId { get; set; }
        [Display(Name = "Organizator")]
        public int OrgId { get; set; }
        [Display(Name = "Styl")]
        public int ThemeId { get; set; }
       
     

    }
}
