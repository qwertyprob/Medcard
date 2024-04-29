using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Medcard.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<MedcardModel> ExistingNames { get; set; } = new List<MedcardModel>(); 

        public static List<MedcardModel> StaticListModel { get; set; } = new List<MedcardModel>();
        

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        private static int counter=1;


        public void OnGet()
        {
            ExistingNames = StaticListModel; 
            
        }
        public IActionResult OnPost(string name,string phonenumber,string petname,int? chipnumber,int age,string breed)
        {
            ExistingNames = StaticListModel;
            
            MedcardModel model = new MedcardModel()
            {   
                Id=counter++,
                Name = name,
                PhoneNumber= phonenumber,
                PetName = petname,
                ChipNumber = chipnumber,
                Age = age,
                Breed = breed 

            };

            ExistingNames.Add(model);
            
            return RedirectToPage("/Index");
        }

        
    }
}