﻿using System.ComponentModel.DataAnnotations;

namespace Silicon_Web_App.ViewModels;

public class SignUpViewModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Your first name")]
    [Required(ErrorMessage = "A valid first name is required")]
    public string FirstName { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Your last name")]
    [Required(ErrorMessage = "A valid last name is required")]
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email address", Prompt = "Your email address")]
    [Required(ErrorMessage = "A valid email address is required")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Your password")]
    [Required(ErrorMessage = "A valid password is required")]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Password must be confirmed")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name ="I agree to the Terms & Conditions.")]
    //[CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions to proceed")]
    [Required(ErrorMessage = "Terms and conditions must be accepted")]
    public bool TermsAndConditions { get; set; }
}
