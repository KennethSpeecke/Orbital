using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers
{
    public class ApplicationUserCommentRequestDto
    {
        #region Properties

        public ApplicationUserRegisterRequestDto ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public BaseSpaceObjectDto SpaceEntity { get; set; }
        public Guid SpaceEntityId { get; set; }
        public string Text { get; set; }

        #endregion Properties
    }
}