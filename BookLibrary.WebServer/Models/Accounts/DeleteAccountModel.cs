﻿using System.ComponentModel.DataAnnotations;

namespace BookLibrary.WebServer.Models.Accounts
{
    public class DeleteAccountModel
    {
        [Required]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Password should be between 8 and 32 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string DeleteAccountMassege { get; set; }
    }
}
