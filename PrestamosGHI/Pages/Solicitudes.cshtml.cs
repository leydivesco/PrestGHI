using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassData;
using ClassModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PrestamosGHI.Pages
{
    public class SolicitudesModel : PageModel
    {
        private IConfiguration configuration;
        public IList<ClassSolicitudes> solicitudes { get; set; }
        public ISolicitudes serviceSolicitudes { get; }
        [BindProperty(SupportsGet =true)]
        public string Texto { get; set; }
        public SolicitudesModel(IConfiguration config,ISolicitudes solicitudesService)
        {
            this.configuration = config;
            this.serviceSolicitudes = solicitudesService;
        }
        public void OnGet()
        {
            this.solicitudes = serviceSolicitudes.GetPorCodigo(Texto);
        }
    }
}