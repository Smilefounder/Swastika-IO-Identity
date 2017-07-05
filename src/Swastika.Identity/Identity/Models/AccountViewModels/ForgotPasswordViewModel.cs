﻿using System.ComponentModel.DataAnnotations;

namespace Swastika.Identity.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
