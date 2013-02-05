using ResourceFilesSample.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResourceFilesSample.Web.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="StreetDisplay",
            ResourceType=typeof(ViewResources))]
        [Required(AllowEmptyStrings=false,
            ErrorMessageResourceName="StreetErrorMandatory",
            ErrorMessageResourceType=typeof(ViewResources))]
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}