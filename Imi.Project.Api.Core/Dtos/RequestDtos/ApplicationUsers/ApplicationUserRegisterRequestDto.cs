﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers
{
    public class ApplicationUserRegisterRequestDto
    {
        #region Properties

        [Required]
        public string Adress { get; set; }

        public DateTime BirthDate { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Username { get; set; }

        #endregion Properties
    }
}