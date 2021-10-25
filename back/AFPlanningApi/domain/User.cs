using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class User 
        : Entity
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }

        public bool Host { get; set; }

    }
}