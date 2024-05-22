using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vzeeta.Model.Enums;

namespace Vzeeta.Model
{
    public class UserIdentity : IdentityUser<int>
    {
        private string? _CertificateImageUrl ="";
        private double? _Salary = 0.0;
        public UserType UserType { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        public int? SpecializationId { get; set; }
        public virtual Specialization? Specialization { get; set; }
        public string? CertificateImageUrl
        {
            get
            {
                return _CertificateImageUrl;
            }
            set
            {
                if (UserType.Equals(UserType.Doctor))
                {
                    _CertificateImageUrl = value;
                }
            }
        }
        public double? Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                if (UserType.Equals(UserType.Doctor))
                {
                    _Salary = value;
                }
            }
        }
        public string generateUserName()
        {
            StringBuilder UserName = new StringBuilder("Vzeeta");
            var rand = new Random();
            int x = rand.Next(10, 100);
           
            return UserName.ToString();
        }
        public string generatePassword()
        {
            StringBuilder NewPassword = new StringBuilder("Vzeeta"),
                          HashingSohag = new StringBuilder("sohag"),
                          HashingSymbols = new StringBuilder("!@#$&");
            var rand = new Random();
            int x = 3;
            while (x > 0)
            {
                NewPassword.Append(HashingSohag[rand.Next(HashingSohag.Length - 1)]);
                x--;
            }
            NewPassword.Append(HashingSymbols[rand.Next(HashingSymbols.Length - 1)]);
            x = rand.Next(100, 1001);
            while (x > 0)
            {
                NewPassword.Append(x % 10 + '0');
                x /= 10;
            }
            return NewPassword.ToString();
        }

    }
   
}
