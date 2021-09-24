using Microsoft.AspNetCore.Components;

namespace Imi.Project.Blazor.Shared
{
    public partial class PlayerName
    {
        #region Properties

        [ParameterAttribute]
        public string Name { get; set; }

        #endregion Properties
    }
}