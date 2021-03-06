﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O email é necessário")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é necessária")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
