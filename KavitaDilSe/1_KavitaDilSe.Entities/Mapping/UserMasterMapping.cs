using _1_KavitaDilSe.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KavitaDilSe.Entities.Mapping
{
    public class UserMasterMapping : EntityTypeConfiguration<UserMasterModel>
    {
        public UserMasterMapping() : this("dbo")
        {
        }

        public UserMasterMapping(string schema)
        {
            ToTable("UserMaster", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"UserId")
                                       .HasColumnType("int")
                                       .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                                       .IsRequired();

            Property(x => x.UserName).HasColumnName(@"UserName")
                                    .HasColumnType("varchar")
                                    .IsRequired()
                                    .HasMaxLength(100)
                                    .IsUnicode(false);

            Property(x => x.EmailId).HasColumnName(@"EmailId")
                                    .HasColumnType("varchar")
                                    .IsRequired()
                                    .HasMaxLength(100)
                                    .IsUnicode(false);

            Property(x => x.FirstName).HasColumnName(@"FirstName")
                                    .HasColumnType("varchar")
                                    .IsRequired()
                                    .HasMaxLength(100)
                                    .IsUnicode(false);

            Property(x => x.LastName).HasColumnName(@"LastName")
                                    .HasColumnType("varchar")
                                    .IsRequired()
                                    .HasMaxLength(100)
                                    .IsUnicode(false);

            Property(x => x.IsActiveUser).HasColumnName(@"IsActiveUser")
                                    .HasColumnType("bit")
                                    .IsRequired();
                                    
            Property(x => x.UserStamp).HasColumnName(@"UserStamp")
                                      .HasColumnType("varchar")
                                      .IsUnicode(false)
                                      .IsRequired()
                                      .HasMaxLength(15);

            Property(x => x.TimeStamp).HasColumnName(@"TimeStamp")
                                      .HasColumnType("datetime")
                                      .IsRequired();
        }
    }
}
