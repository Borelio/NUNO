﻿using NUNO_Backend.Helpers.Validators;
using System.ComponentModel.DataAnnotations;

namespace NUNO_Backend.Models.BindingModels {
  public class RegisterBindingModel {
    [Required]
    [EmailValidation]
    [EmailExists]
    public string Email { get; set; }
    [Required]
    [UsernameExists]
    public string Username { get; set; }
    [Required]
    [PasswordValidation]
    public string Password { get; set; }
  }
}
