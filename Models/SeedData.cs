using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PenCompany.Data;
using System;
using System.Linq;

namespace PenCompany.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PenCompanyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PenCompanyContext>>()))
            {
                // Look for any movies.
                if (context.Pen.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pen.AddRange(
                    new Pen
                    {
                        Title = "Signature Series",
                        ReleaseDate = DateTime.Parse("2020-10-20"),
                        CompanyName = "Montblanc",
                        Color = "Black",
                        Material = " Metal and Resin",
                        InkType = "Black",
                        IsRefillable = true,
                        Price = 7.99M
                    },

                     new Pen
                     {
                         Title = "Elegance Plus",
                         ReleaseDate = DateTime.Parse("2020-01-15"),
                         CompanyName = "Parker",
                         Color = "Green",
                         Material = " Metal and Resin",
                         InkType = "Green",
                         IsRefillable = false,
                         Price = 5.98M
                     },

                     new Pen
                     {
                         Title = "GelWriter Pro",
                         ReleaseDate = DateTime.Parse("2019-03-10"),
                         CompanyName = "Bic",
                         Color = "Purple",
                         Material = "Plastic",
                         InkType = "Purple",
                         IsRefillable = true,
                         Price = 8.56M
                     },

                      new Pen
                      {
                          Title = "Precise V5",
                          ReleaseDate = DateTime.Parse("2018-07-05"),
                          CompanyName = "Pilot",
                          Color = "Grey",
                          Material = "Plastic",
                          InkType = "Grey",
                          IsRefillable = true,
                          Price = 7.99M
                      },

                      new Pen
                      {
                          Title = "Luxury Inkmaster",
                          ReleaseDate = DateTime.Parse("2021-04-03"),
                          CompanyName = "Cross",
                          Color = "Pink",
                          Material = "Metal and Acrylic",
                          InkType = "Pink",
                          IsRefillable = false,
                          Price = 6.79M
                      },

                       new Pen
                       {
                           Title = "Executive Elegance",
                           ReleaseDate = DateTime.Parse("2020-11-30"),
                           CompanyName = "Waterman",
                           Color = "Yellow",
                           Material = "Metal and Resin",
                           InkType = "Yellow",
                           IsRefillable = true,
                           Price = 9.87M
                       },

                      new Pen
                      {
                          Title = "InkJoy 300RT",
                          ReleaseDate = DateTime.Parse("2019-05-12"),
                          CompanyName = "Sharpie",
                          Color = "orange",
                          Material = "Plastic",
                          InkType = "orange",
                          IsRefillable = true,
                          Price = 8.67M
                      },

                    new Pen
                    {
                        Title = "SmoothGlide ",
                        ReleaseDate = DateTime.Parse("2017-02-08"),
                        CompanyName = "Paper Mate",
                        Color = "white",
                        Material = " Plastic",
                        InkType = "Blue",
                        IsRefillable = true,
                        Price = 5.89M
                    },

                    new Pen
                    {
                        Title = "SilkGrip Comfort",
                        ReleaseDate = DateTime.Parse("2018-06-07"),
                        CompanyName = "Uni-ball",
                        Color = "Blue",
                        Material = " Plastic",
                        InkType = "Blue",
                        IsRefillable = false,
                        Price = 9.99M
                    },

                    new Pen
                    {
                        Title = "Classic Clicker",
                        ReleaseDate = DateTime.Parse("2016-09-14"),
                        CompanyName = "Zebra",
                        Color = "Red",
                        Material = " Plastic",
                        InkType = "Red",
                        IsRefillable = true,
                        Price = 8.55M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}