using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.Base
{
    public abstract class BasePersonModel<TKey>
    {
        #region Properties

        public byte Age { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public TKey Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? ObitDate { get; set; }
        public string Surname { get; set; }

        #endregion Properties

        //Date of death
    }
}