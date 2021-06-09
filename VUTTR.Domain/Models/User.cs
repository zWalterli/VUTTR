using System;
using VUTTR.Domain.DTOs;

namespace VUTTR.Domain.Models
{
    public class User
    {
        #region Constructor
        public User() {}
        public User(UserDto user)
        {
            this.UserId = user.UserId;
            this.UserName = user.FullName;
            this.Password = user.Password;
            this.FullName = user.FullName;
            this.RefreshToken = user.RefreshToken;
            this.RefreshTokenExpiryTime = user.RefreshTokenExpiryTime;
        }
        public User(string refreshToken, DateTime refreshTokenExpiryTime)
        {
            RefreshToken = refreshToken;
            RefreshTokenExpiryTime = refreshTokenExpiryTime;
        }
        #endregion
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}