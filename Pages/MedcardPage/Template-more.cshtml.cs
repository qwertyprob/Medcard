using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Medcard.Pages;
using static Medcard.Pages.IndexModel;
using System.Xml.Linq;
using System.Linq;

namespace Medcard.Pages.MedcardPage
{
    public class Template_moreModel : PageModel
    {
        private readonly ILogger<Template_moreModel> _logger;
        //��� ������� � ������������ ������ 
        [BindProperty(SupportsGet = true)]
        public List<MedcardModel> medcard { get; set; } = new List<MedcardModel>();
        
        public Template_moreModel(ILogger<Template_moreModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int id)
        {   //��������� ���� � ���� �� ������ ������� �� ������ ��� ������ id � url
            medcard.Add(StaticListModel[id-1]);  
        }
        public IActionResult OnPost(int id)
        {
            return RedirectToPage($"/Update/{id-1}"); ;
        }
    }
}
