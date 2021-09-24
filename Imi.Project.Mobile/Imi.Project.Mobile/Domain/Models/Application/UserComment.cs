using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;

namespace Imi.Project.Mobile.Domain.Models.Application
{
    public class UserComment
    {
        #region Properties

        public ApplicationUser ApplicationUser { get; set; }
        public string Comment { get; set; }
        public Guid Id { get; set; }
        public SpaceBaseItemViewModel<Guid> SpaceItemModel { get; set; }

        #endregion Properties
    }
}