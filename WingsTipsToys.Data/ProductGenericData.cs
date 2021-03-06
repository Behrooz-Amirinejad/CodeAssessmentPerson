using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WingTipsToys.Data.Infrastructure;
using WingTipsToys.Model;

namespace WingTipsToys.Data
{
      public class ProductGenericData : AppEntityTypeConfiguration<ProductModel>
      {
            public override void Configure(EntityTypeBuilder<ProductModel> builder)
            {
                  builder.HasKey(x => x.ProductID);
                  builder.Property(x => x.ProductName);
            }
      }
}
