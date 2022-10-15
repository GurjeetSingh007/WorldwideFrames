
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WorldwideFrames.Data;
using System;
using System.Linq;

namespace WorldwideFrames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorldwideFramesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WorldwideFramesContext>>()))
            {
                // Look for any movies.
                if (context.Frame.Any())
                {
                    return;   // DB has been seeded
                }

                context.Frame.AddRange(
                    new Frame
                    {
                        FrameType = "Unfinished",
                        FrameStyle = "Art Deco",
                        Color = "Off White",
                        FrameHeight = 13.2M,
                        FrameWidth = 8.1M,
                        FramePrice = 9.4M
                    },
                    new Frame
                    {
                        FrameType = "Varnished",
                        FrameStyle = "Casual",
                        Color = "Silver",
                        FrameHeight = 18,
                        FrameWidth = 12,
                        FramePrice = 26
                    },
                    new Frame
                    {
                        FrameType = "Collage",
                        FrameStyle = "Baroque",
                        Color = "Green",
                        FrameHeight = 12.3M,
                        FrameWidth = 6.9M,
                        FramePrice = 8.3M
                    },
                    new Frame
                    {
                        FrameType = "Polished",
                        FrameStyle = "Bohemian",
                        Color = "Grey",
                        FrameHeight = 12.9M,
                        FrameWidth = 7M,
                        FramePrice = 11
                    },
                    new Frame
                    {
                        FrameType = "Brushed",
                        FrameStyle = "Lacquered",
                        Color = "Black",
                        FrameHeight = 9.99M,
                        FrameWidth = 5.2M,
                        FramePrice = 12
                    },
                    new Frame
                    {
                        FrameType = "Painted",
                        FrameStyle = "Antique",
                        Color = "light Red",
                        FrameHeight = 14,
                        FrameWidth = 11,
                        FramePrice = 15
                    },
                    new Frame
                    {
                        FrameType = "Wall",
                        FrameStyle = "Rustic",
                        Color = "LightBlack",
                        FrameHeight = 15,
                        FrameWidth = 12,
                        FramePrice = 17.5M
                    },
                    new Frame
                    {
                        FrameType = "Single Picture",
                        FrameStyle = "Coastal",
                        Color = "Brown",
                        FrameHeight = 18M,
                        FrameWidth = 11M,
                        FramePrice = 32.99M
                    },
                    new Frame
                    {
                        FrameType = "Uninished",
                        FrameStyle = "Shabby Chic",
                        Color = "White",
                        FrameHeight = 12.99M,
                        FrameWidth = 8.9M,
                        FramePrice = 16.4M
                    },
                    new Frame
                    {
                        FrameType = "Floater",
                        FrameStyle = "Classic",
                        Color = "Cream",
                        FrameHeight = 15M,
                        FrameWidth = 12.2M,
                        FramePrice = 29.7M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}