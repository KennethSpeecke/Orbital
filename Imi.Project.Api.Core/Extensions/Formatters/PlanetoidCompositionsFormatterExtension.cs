using Imi.Project.Api.Core.Entities.SpaceObjects;
using System.Text;

namespace Imi.Project.Api.Core.Extensions.Formatters
{
    public static class PlanetoidCompositionsFormatterExtension
    {
        #region Methods

        public static string FormatCompositionCollectionToString(SpacePlanetoidEntity spacePlanetoidEntity)
        {
            var compositions = spacePlanetoidEntity.Compositions;
            StringBuilder sb = new StringBuilder("");
            foreach (var composition in compositions)
            {
                sb.Append($"{composition.TypeName} ");
            }
            return sb.ToString();
        }

        #endregion Methods
    }
}