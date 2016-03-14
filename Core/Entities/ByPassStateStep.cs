using System;
using Core.Entities.Base;

namespace Core.Entities
{
    public class ByPassStateStep : ByPassBase
    {
        public Guid DepartmentId { get; set; }

        public Guid ApprovedChiefId { get; set; }

        public Guid ByPassStateId { get; set; }

        public virtual Department Department { get; set; }

        public virtual User ApprovedChief { get; set; }

        public virtual ByPassState ByPassState { get; set; }
    }
}
