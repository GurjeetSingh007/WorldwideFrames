using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldwideFrames.Models
{
    public class Frame
    {
        public int Id { get; set; }
        public string FrameType { get; set; }
        public string FrameStyle { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal FrameHeight { get; set; }

        [Column(TypeName = "decimal(7, 2)")]
        public decimal FrameWidth { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal FramePrice { get; set; }
    }
}
