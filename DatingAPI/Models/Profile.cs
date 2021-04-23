using System;
namespace DatingAPI.Models
{
    public class Profile
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GenderId { get; set; }
        public decimal Height { get; set; }
    }
}
