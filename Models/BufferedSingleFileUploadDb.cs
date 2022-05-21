using System.ComponentModel.DataAnnotations;

namespace CANBOOKRAM_V01.Models
{
    public class BufferedSingleFileUploadDb
    {
        [Required(ErrorMessage = "Profile Picture is required.")]
        [Display(Name = "Profile Picture")]
        public IFormFile? FormFile { get; set; }
    }
}
