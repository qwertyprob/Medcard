using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using static Medcard.Pages.IndexModel;
using System.Collections.Generic;

namespace Medcard.Pages.MedcardPage
{
    public class Template_more_updateModel : PageModel
    {
        private readonly ILogger<Template_more_updateModel> _logger;
        [BindProperty(SupportsGet = true)]
        public List<MedcardModel> medcard { get; set; } = new List<MedcardModel>();

        public Template_more_updateModel(ILogger<Template_more_updateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int id)
        {   //Добавляем инфу в поле по такому индексу по какому нам далось id в url
            medcard.Add(StaticListModel[id]);
        }
    }
}
