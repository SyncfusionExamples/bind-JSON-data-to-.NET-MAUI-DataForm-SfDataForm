using Syncfusion.Maui.DataForm;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoadJSONData
{
    public class DataFormModel
    {
        public DataFormModel()
        {
            this.Name = string.Empty;
            this.Department = string.Empty;
            this.Role= string.Empty;
            this.Branch = string.Empty;
            this.City = string.Empty;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your first name")]
        [StringLength(20, ErrorMessage = "First name should not exceed 20 characters")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Department")]
        public string Department { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your Role")]
        public string Role { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select your city")]
        public string Branch { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your country")]
        public string City { get; set; }
    }
}