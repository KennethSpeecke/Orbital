using Imi.Project.Api.Core.Entities.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ImagesSeeder
    {
        const string cosmos2251DebrisId = "46f23e53-093c-44ab-9427-9b03cd08dd8f";
        const string iridium33DebrisId = "ffebf84b-b0cd-4bab-91a6-dd3024f81968";
        const string sl16DebrisId = "99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d";
        const string envisatDebrisId = "4fd5e7e7-3516-425a-a8c7-28ee8b89596a";
        const string adeosDebrisId = "5552205c-ad29-4f80-adb1-c357b17373f8";

        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<BaseImageEntity>().HasData(
                    new BaseImageEntity {Id = Guid.Parse("c068ab92-d240-49bb-a71b-0acdde861131"), SpaceEntityId = Guid.Parse(cosmos2251DebrisId), Uri = new Uri("Cosmos2251-c068ab92-d240-49bb-a71b-0acdde861131.jpg", UriKind.Relative) },
                    new BaseImageEntity {Id = Guid.Parse("6b28f5c2-12cd-46ff-a525-ddcdce16b0b4"), SpaceEntityId = Guid.Parse(cosmos2251DebrisId), Uri = new Uri("Cosmos2251-6b28f5c2-12cd-46ff-a525-ddcdce16b0b4.jpg", UriKind.Relative) },
                    new BaseImageEntity {Id = Guid.Parse("bcc47fac-1a42-41a1-9fa1-8b91d2c8b153"), SpaceEntityId = Guid.Parse(cosmos2251DebrisId), Uri = new Uri("Cosmos2251-bcc47fac-1a42-41a1-9fa1-8b91d2c8b153.jpg", UriKind.Relative) },

                    new BaseImageEntity {Id = Guid.Parse("f7396475-3304-4e27-b2bb-7fd557184199"), SpaceEntityId = Guid.Parse(iridium33DebrisId), Uri = new Uri("Iridium33-f7396475-3304-4e27-b2bb-7fd557184199.jpg", UriKind.Relative) },
                    new BaseImageEntity {Id = Guid.Parse("d89db8a6-6c61-4c6f-869e-f2dec992b89d"), SpaceEntityId = Guid.Parse(iridium33DebrisId), Uri = new Uri("Iridium33-d89db8a6-6c61-4c6f-869e-f2dec992b89d.jpg", UriKind.Relative) },
                    new BaseImageEntity {Id = Guid.Parse("6eb4a73b-95d5-4bf6-8ab1-92e597fa9909"), SpaceEntityId = Guid.Parse(iridium33DebrisId), Uri = new Uri("Iridium33-6eb4a73b-95d5-4bf6-8ab1-92e597fa9909.jpg", UriKind.Relative) },

                    new BaseImageEntity {Id = Guid.Parse("1e5c583b-1211-479e-bb6f-83e744ea9562"), SpaceEntityId = Guid.Parse(sl16DebrisId), Uri = new Uri("SL16-1e5c583b-1211-479e-bb6f-83e744ea9562.jpg", UriKind.Relative) },

                    new BaseImageEntity {Id = Guid.Parse("ba76ce34-7eb0-4e28-92af-4b1701051785"), SpaceEntityId = Guid.Parse(envisatDebrisId), Uri = new Uri("Envisat-ba76ce34-7eb0-4e28-92af-4b1701051785.jpg", UriKind.Relative) },

                    new BaseImageEntity {Id = Guid.Parse("082f1641-cd03-46f3-a484-e2d4b0929849"), SpaceEntityId = Guid.Parse(adeosDebrisId), Uri = new Uri("Adeos-082f1641-cd03-46f3-a484-e2d4b0929849.jpg", UriKind.Relative) }
                );
        }
    }
}
