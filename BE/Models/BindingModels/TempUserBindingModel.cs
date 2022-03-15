﻿using NUNO_Backend.Helpers.Validators;
using System.ComponentModel.DataAnnotations;

namespace NUNO_Backend.Models.BindingModels {
  public class TempUserBindingModel {
    [Required(ErrorMessage = "Der Benutzername muss angegeben werden")]
    [DoesntContain('@', ErrorMessage = "Der Benutzername darf kein '@' beinhalten")]
    [UsernameExists]
    public string Username { get; set; }
  }
}
