using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;

namespace Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers
{
    public interface IUserCommentService : IService<ApplicationUserCommentResponseDto, ApplicationUserCommentRequestDto>
    {
    }
}