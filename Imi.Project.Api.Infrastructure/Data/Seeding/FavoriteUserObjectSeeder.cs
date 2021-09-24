using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class FavoriteUserObjectSeeder
    {
        #region Fields

        private const string adeosDebrisId = "5552205c-ad29-4f80-adb1-c357b17373f8";
        private const string admiralChunckyUserId = "b9f3599b-ba5d-4799-8fd4-77a7e4023be6";
        private const string colonelChunckyUserId = "34d82894-cd34-40a6-a19e-881ca98451f7";
        private const string corporalChunckyUserId = "8d5213cb-1abc-43e3-a4d6-35b92e829f6f";
        private const string cosmos2251DebrisId = "46f23e53-093c-44ab-9427-9b03cd08dd8f";
        private const string envisatDebrisId = "4fd5e7e7-3516-425a-a8c7-28ee8b89596a";
        private const string iridium33DebrisId = "ffebf84b-b0cd-4bab-91a6-dd3024f81968";
        private const string recruitChunckyUserId = "ced8f1e3-fbab-4db1-99a1-fa45b1428c21";
        private const string sergeantChunckyUserId = "86b9ff3d-5188-43e5-9c8d-f7f46823ce73";
        private const string sl16DebrisId = "99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d";

        #endregion Fields

        #region Methods

        public static void Seed(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<FavoriteUserObject>().HasData(
                    new FavoriteUserObject { SpaceObjectId = Guid.Parse(cosmos2251DebrisId), UserId = $"{admiralChunckyUserId}" },
                    new FavoriteUserObject { SpaceObjectId = Guid.Parse(iridium33DebrisId), UserId = $"{admiralChunckyUserId}" },
                    new FavoriteUserObject { SpaceObjectId = Guid.Parse(sl16DebrisId), UserId = $"{admiralChunckyUserId}" },
                    new FavoriteUserObject { SpaceObjectId = Guid.Parse(envisatDebrisId), UserId = $"{admiralChunckyUserId}" },
                    new FavoriteUserObject { SpaceObjectId = Guid.Parse(adeosDebrisId), UserId = $"{admiralChunckyUserId}" }
                );
        }

        #endregion Methods
    }
}