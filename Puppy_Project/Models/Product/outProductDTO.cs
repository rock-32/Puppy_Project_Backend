﻿namespace Puppy_Project.Models.Product
{
    public class outProductDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string About { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int Category_id { get; set; }
    }
}