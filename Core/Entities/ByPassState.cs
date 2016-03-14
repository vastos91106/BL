using System;
using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class ByPassState : ByPassBase
    {
        public int Position { get; set; }

        public Guid ByPassListId { get; set; }

        public virtual ByPassList ByPassList { get; set; }

        public virtual IEnumerable<ByPassStateStep> StateSteps { get; set; }
    }
}
