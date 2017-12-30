﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Swastika.Identity.Data
{
    public static class IdentityBasedData
    {
        public static List<string> UserClaims { get; set; } = new List<string>
                                                            {
                                                                "Add User",
                                                                "Edit User",
                                                                "Delete User"
                                                            };
    }
}
