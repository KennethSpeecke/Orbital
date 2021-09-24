using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Repositories.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.ApplicationUsers
{
    public class UserService : IUserService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        #endregion Fields

        #region Constructors

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        #endregion Constructors

        #region Methods

        public Task<ApplicationUserLoginResponseDto> AddAsync(ApplicationUserRegisterRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserLoginResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUserByEmail(string userEmail)
        {
            var foundUser = await _userRepository.GetUserByEmail(userEmail);
            return foundUser;
        }

        public async Task<IEnumerable<ApplicationUserLoginResponseDto>> ListAllAsync()
        {
            var users = _userRepository.GetAllAsync();
            var responseDto = _mapper.Map<IEnumerable<ApplicationUserLoginResponseDto>>(users);
            return await Task.FromResult(responseDto);
        }

        public Task<ApplicationUserLoginResponseDto> UpdateAsync(ApplicationUserRegisterRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}