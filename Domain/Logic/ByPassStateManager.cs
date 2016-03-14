using System;
using System.Data.Entity;
using System.Linq;
using Core;
using Core.Entities;
using Domain.Implementation;

namespace Domain.Logic
{
    class ByPassStateManager : IByPassState
    {
        public bool UpdateByPassState(ByPassState byPassStateEntity)
        {
            try
            {
                using (var dbContext = new EntityContext())
                {
                    var model = dbContext.Set<ByPassState>().Find(byPassStateEntity.Id);
                    if (model == null)
                        return false;

                    if (!model.IsComplete)
                    {
                        var isStateStepsCompleted = model.StateSteps.Any(steps => !steps.IsComplete);

                        if (isStateStepsCompleted)
                            return false;

                        model.IsComplete = byPassStateEntity.IsComplete;
                        dbContext.Entry(model).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
