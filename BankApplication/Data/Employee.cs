using Microsoft.AspNetCore.Identity;


namespace SensationalScentsWeb.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? Address { get; set; }
        public DateTime DatofBirth { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? TRN { get; set; }
    }
}
