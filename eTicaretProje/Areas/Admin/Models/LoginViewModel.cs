using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class LoginViewModel
    {
        public int KullaniciID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}