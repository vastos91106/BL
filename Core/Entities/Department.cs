using System;
using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class Department : EntityBaseGuid
    {
        public string Name { get; set; }

        public string Details { get; set; }

        public Nullable<Guid> ChiefId { get; set; }

        public virtual User Chief { get; set; }

        public virtual IEnumerable<User> Workers { get; set; }

        public virtual IEnumerable<ByPassStateStep> DepartmentByPassStateSteps { get; set; }
    }
}
