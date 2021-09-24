using System;

namespace Imi.Project.Blazor.Models.Application
{
    public class ApplicationSettings
    {
        #region Properties

        public Guid CurrentUserId { get; set; }
        public bool EnableLocationTracking { get; set; }
        public bool EnableNotifications { get; set; }

        #endregion Properties
    }
}