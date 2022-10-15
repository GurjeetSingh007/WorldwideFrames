using System;
using System.ComponentModel.DataAnnotations;

namespace WorldwideFrames.Models
{
    public class Frame
    {
        public int Id { get; set; }
        public string FrameType { get; set; }
        public string FrameStyle { get; set; }
        public string Color { get; set; }


        public decimal FrameHeight { get; set; }
        public decimal FrameWidth { get; set; }
        public decimal FramePrice { get; set; }
    }
}
