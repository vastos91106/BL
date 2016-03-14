using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Entities;
using Domain.Implementation;

namespace Domain.Logic
{
    public class ByPassListManager : IByPassList
    {
        public IEnumerable<ByPassList> GetLists()
        {
            try
            {
                using (var dbContext = new EntityContext())
                {
                    return dbContext.Set<ByPassList>().ToList();
                }
            }
            catch (Exception)
            {
                //log exception
                return null;
            }

        }

        public ByPassList GetList(Guid id)
        {
            try
            {
                using (var dbContext = new EntityContext())
                {
                    return dbContext.Set<ByPassList>().FirstOrDefault(list => list.Id == id);
                }
            }
            catch (Exception)
            {
                //log exception
                return null;
            }
        }

        public bool Create(ByPassList bypassEntity)
        {
            try
            {
                using (var dbContext = new EntityContext())
                {
                    dbContext.Set<ByPassList>().Add(bypassEntity);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                //log exception
                return false;
            }
            return true;
        }
    }
}
