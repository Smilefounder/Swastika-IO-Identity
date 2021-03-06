﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Swastika.Identity.Models.AccountViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        [Display(Name = "User Claims")]
        public List<SelectListItem> UserClaims { get; set; }
    }
}