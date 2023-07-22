﻿using Microsoft.EntityFrameworkCore;

namespace TPH.Models
{
    [Owned]
	public class RefreshToken
	{
        public string Token { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public DateTime? RevokedOn { get; set; }

        public bool IsExpired => DateTime.Now >= ExpiresOn;


        public bool IsActive => RevokedOn is null && !IsExpired; 
    }
}
