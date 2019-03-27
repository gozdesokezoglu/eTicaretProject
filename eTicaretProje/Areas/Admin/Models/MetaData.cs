using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class SliderMetaData
    {
        [Required]
        [Display(Name = "Slider Yazısı")]
        public string SliderText { get; set; }
    }
}