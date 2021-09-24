using Imi.Project.Blazor.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.Application
{
    public class ApplicationUser : BasePersonModel<Guid>
    {
        #region Properties

        public string Adress { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //GeoLocation properties
        public double Latitude { get; set; }

        public double Longtitude { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username has to be between 3 and 20 charcters in lenght.")]
        public string UserName { get; set; }

        #endregion Properties
    }
}