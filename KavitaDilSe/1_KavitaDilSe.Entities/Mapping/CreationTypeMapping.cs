using _1_KavitaDilSe.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace _1_KavitaDilSe.Entities.Mapping
{
    public class CreationTypeMapping : EntityTypeConfiguration<CreationTypeMasterModel>
    {
        public CreationTypeMapping() : this("dbo")
        {
        }

        public CreationTypeMapping(string schema)
        {
            ToTable("CreationTypeMaster", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"CreationType_id")
                                       .HasColumnType("int")
                                       .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                                       .IsRequired();
                                       
            Property(x => x.TypeName).HasColumnName(@"TypeName")
                                    .HasColumnType("varchar")
                                    .IsRequired()
                                    .HasMaxLength(100)
                                    .IsUnicode(false);

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
