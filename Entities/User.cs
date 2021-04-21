using System;

namespace Project.Last.Entities
{
    public enum AccessLevel
    {
        NONE=0,
        REGULAR=1,
        MANAGER=2,
        ADMIN=3
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AccessLevel Access { get; set; }
        public MedOrg Med { get; set; }
        public User()
        {
        }
    }
}
