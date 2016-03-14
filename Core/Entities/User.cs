using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Base;

namespace Core.Entities
{
    public class User : EntityBaseGuid
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Inn { get; set; }

        public Guid DepartmentId { get; set; }

        public virtual IEnumerable<Department> UserDepartments { get; set; }

        public virtual IEnumerable<Department> ChiefDepartments { get; set; }

        public virtual IEnumerable<ByPassList> BypassLists { get; set; }
    }
}
