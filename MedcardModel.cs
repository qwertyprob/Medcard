using Microsoft.AspNetCore.Mvc;
using System;

namespace Medcard
{
    public class MedcardModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PetName { get; set; }
        public int? ChipNumber { get; set; }

        private int age;
        public int Age
        {
            get
            {
                if (age < 0)
                    return 1 ;
                  
                return age;
            }
            set
            {
                if (value >= age)
                    age = value;
            }
        }

        public string Breed { get; set; }


    }
}
