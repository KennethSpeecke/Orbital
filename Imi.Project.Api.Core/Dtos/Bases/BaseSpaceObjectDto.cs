using Imi.Project.Api.Core.Entities.Enums;
using System;

namespace Imi.Project.Api.Core.Dtos.Bases
{
    public class BaseSpaceObjectDto : BaseDto<Guid>
    {
        #region Properties

        public int ApogeeInKm { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public double Mass { get; set; }
        public string Name { get; set; }
        public int PerigeeInKm { get; set; }
        public string ShortName { get; set; }
        public double Size { get; set; }
        public SpaceObjectTypes SpaceObjectType { get; set; }
        public Uri ThumbnailImage { get; set; }

        #endregion Properties
    }
}