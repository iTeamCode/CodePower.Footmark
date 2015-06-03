using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_ITEM_OPTIONMap : EntityTypeConfiguration<FORM_ITEM_OPTION>
    {
        public FORM_ITEM_OPTIONMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ITEM_OPTION_ID);

            // Properties
            this.Property(t => t.TEXT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OPTION_VALUE)
                .HasMaxLength(100);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_ITEM_OPTION");
            this.Property(t => t.FORM_ITEM_OPTION_ID).HasColumnName("FORM_ITEM_OPTION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_ITEM_ID).HasColumnName("FORM_ITEM_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.TEXT).HasColumnName("TEXT");
            this.Property(t => t.OPTION_VALUE).HasColumnName("OPTION_VALUE");
            this.Property(t => t.PAY_PRICING_ITEM_ID).HasColumnName("PAY_PRICING_ITEM_ID");
            this.Property(t => t.IS_DEFAULT).HasColumnName("IS_DEFAULT");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasOptional(t => t.ACTIVITY)
                .WithMany(t => t.FORM_ITEM_OPTION)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.FORM_ITEM_OPTION)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.FORM_ITEM)
                .WithMany(t => t.FORM_ITEM_OPTION)
                .HasForeignKey(d => d.FORM_ITEM_ID);
            this.HasOptional(t => t.INDIVIDUAL_GROUP)
                .WithMany(t => t.FORM_ITEM_OPTION)
                .HasForeignKey(d => d.INDIVIDUAL_GROUP_ID);
            this.HasOptional(t => t.PAY_PRICING_ITEM)
                .WithMany(t => t.FORM_ITEM_OPTION)
                .HasForeignKey(d => d.PAY_PRICING_ITEM_ID);

        }
    }
}
