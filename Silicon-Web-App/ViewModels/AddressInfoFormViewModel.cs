using System.ComponentModel.DataAnnotations;

namespace Silicon_Web_App.ViewModels;

public class AddressInfoFormViewModel
{
    [Required(ErrorMessage = "A valid address line is required")]
    [DataType(DataType.Text)]
    [Display(Name = "Address line 1", Prompt = "Enter your first address line")]
    public string AddressLine_1 { get; set; } = null!;

    
    [DataType(DataType.Text)]
    [Display(Name = "Address line 2 (optional)", Prompt = "Enter your second address line")]
    public string? AddressLine_2 { get; set; }

    [Required(ErrorMessage = "A valid postal is required")]
    [DataType(DataType.Text)]
    [Display(Name = "Postal code", Prompt = "Enter your postal name")]
    public string PostalCode { get; set; } = null!;

    [Required(ErrorMessage = "A valid city required")]
    [DataType(DataType.Text)]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}
