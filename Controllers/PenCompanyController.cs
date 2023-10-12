using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PenCompany.Controllers

{
    public class PenCompanyController : Controller

    {
        // 
        // GET: /PenCompany

        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /PenCompany/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
