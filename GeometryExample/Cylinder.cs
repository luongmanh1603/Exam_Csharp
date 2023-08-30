using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double Radius {  get; set; }
        private double Height { get; set;}
        public void Process()
        {
            Console.WriteLine("Nhap ban kinh cua xi lanh: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập chiều cao của xi lanh: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void Result()
        {
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;

            Console.WriteLine("Kết quả tính toán:");
            Console.WriteLine($"Diện tích đáy: {BaseArea}");
            Console.WriteLine($"Diện tích bề mặt xung quanh: {LateralArea}");
            Console.WriteLine($"Tổng diện tích bề mặt: {TotalArea}");
            Console.WriteLine($"Thể tích: {Volume}");
        }
    }
}
