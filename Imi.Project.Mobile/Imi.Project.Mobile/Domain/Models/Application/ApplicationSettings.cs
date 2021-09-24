using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models.Application
{
    public class ApplicationSettings
    {
        public Guid CurrentUserId { get; set; }
        public bool EnableNotifications { get; set; }
        public bool EnableLocationTracking { get; set; }
    }
}
