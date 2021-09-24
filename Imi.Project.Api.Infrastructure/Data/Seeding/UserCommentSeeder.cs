using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserCommentSeeder
    {
        const string admiralChunckyUserId = "b9f3599b-ba5d-4799-8fd4-77a7e4023be6";
        const string colonelChunckyUserId = "34d82894-cd34-40a6-a19e-881ca98451f7";
        const string sergeantChunckyUserId = "86b9ff3d-5188-43e5-9c8d-f7f46823ce73";
        const string corporalChunckyUserId = "8d5213cb-1abc-43e3-a4d6-35b92e829f6f";
        const string recruitChunckyUserId = "ced8f1e3-fbab-4db1-99a1-fa45b1428c21";

        const string cosmos2251DebrisId = "46f23e53-093c-44ab-9427-9b03cd08dd8f";
        const string iridium33DebrisId = "ffebf84b-b0cd-4bab-91a6-dd3024f81968";
        const string sl16DebrisId = "99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d";
        const string envisatDebrisId = "4fd5e7e7-3516-425a-a8c7-28ee8b89596a";
        const string adeosDebrisId = "5552205c-ad29-4f80-adb1-c357b17373f8";

        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<UserComment>().HasData(
                    new UserComment {Id = Guid.Parse("75e3838e-6228-40b4-9c60-e9fbc841290b"), IsDeleted = false, Text = "Such a shame that its gone!", ApplicationUserId = Guid.Parse(admiralChunckyUserId), SpaceEntityId = Guid.Parse(cosmos2251DebrisId) },
                    new UserComment {Id = Guid.Parse("ece72624-77c6-4386-abbd-6f5aac6c2a5e"), IsDeleted = false, Text = "What a beauty!", ApplicationUserId = Guid.Parse(colonelChunckyUserId), SpaceEntityId = Guid.Parse(iridium33DebrisId) },
                    new UserComment {Id = Guid.Parse("00bcbe48-f5f3-4a01-b564-144af5ae332f"), IsDeleted = false, Text = "We are number one", ApplicationUserId = Guid.Parse(sergeantChunckyUserId), SpaceEntityId = Guid.Parse(adeosDebrisId) },
                    new UserComment {Id = Guid.Parse("d63a5fad-ace9-46da-be26-3c955c5f8085"), IsDeleted = false, Text = "Im ronny pickering mate", ApplicationUserId = Guid.Parse(corporalChunckyUserId), SpaceEntityId = Guid.Parse(sl16DebrisId) },
                    new UserComment {Id = Guid.Parse("fdd2f797-8f61-474f-bb30-05a373b19055"), IsDeleted = false, Text = "nasa is a hoaxcx", ApplicationUserId = Guid.Parse(recruitChunckyUserId), SpaceEntityId = Guid.Parse(envisatDebrisId) }
                );
        }
    }
}
