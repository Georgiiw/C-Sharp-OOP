using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
            
        }

        private double Length 
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
                length = value;
            }
        }
        private double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public double SurfaceArea()
        {
            double area = 2*(this.Width * this.Height + this.Width * this.Length + this.Length * this.Height);
            return area;
        }
        public double LateralSurfaceArea()
        {
            double leteral = this.Height * 2 * (this.Width + this.Length);
            return leteral;
        }
        public double Volume()
        {
            double volume = this.Width * this.Height * this.Length;
            return volume;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double surfaceArea = SurfaceArea();
            double leteralSurfaceArea = LateralSurfaceArea();
            double volume = Volume();
            sb.AppendLine($"Surface Area - {surfaceArea:f2}");
            sb.AppendLine($"Lateral Surface Area - {leteralSurfaceArea:f2}");
            sb.AppendLine($"Volume - {volume:f2}");

            return sb.ToString().Trim();
        }
    }
}
