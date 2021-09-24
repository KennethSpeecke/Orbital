using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models.Base
{
    public abstract class BasePersonModel<TKey>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? ObitDate { get; set; } //Date of death

    }
}
