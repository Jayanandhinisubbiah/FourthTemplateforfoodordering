using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FourthTemplateforfoodordering.ViewModels
{
    public class UploadImageViewModel
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile FoodPicture { get; set; }
    }
}
