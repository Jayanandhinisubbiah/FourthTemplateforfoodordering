﻿namespace FourthTemplateforfoodordering.ViewModels
{
    public class FoodViewModel:EditImageViewModel
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Detail { get; set; }
        public float Price { get; set; }

        public string CategoryName { get; set; }
    }
}
