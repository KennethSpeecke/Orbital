using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.ApplicationUsers
{
    public class AuthenticationResult
    {
        #region Properties

        public List<string> ErrorMessages { get; set; }
        public bool HasErrors { get; set; }
        public string SuccessMessage { get; set; }
        public string Token { get; set; }

        #endregion Properties
    }
}