﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Api.DTO.UserDTO
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
