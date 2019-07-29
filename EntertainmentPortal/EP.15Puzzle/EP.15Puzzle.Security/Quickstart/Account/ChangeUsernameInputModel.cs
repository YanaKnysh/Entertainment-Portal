﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.ComponentModel.DataAnnotations;

namespace IdentityServer4.Quickstart.UI
{
    public class ChangeUsernameInputModel
    {
        public string Email { get; set; }
        
        public string NewUserName { get; set; }
        [Required]
        public string UserName { get; set; }
       
        public string ReturnUrl { get; set; }

        public ChangeUsernameInputModel(string email, string username,string returnurl)
        {
            UserName = username;
            Email = email;
            ReturnUrl = returnurl;
        }

        public ChangeUsernameInputModel()
        {
            
        }
    }
}
