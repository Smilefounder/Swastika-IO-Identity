﻿using Swastika.Identity.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Swastika.Identity.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
