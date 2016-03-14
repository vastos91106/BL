using System;
using System.Collections.Generic;
using Core.Entities;

namespace Domain.Implementation
{
    public interface IByPassList 
    {
        IEnumerable<ByPassList> GetLists();

        ByPassList GetList(Guid id);

        bool Create(ByPassList bypassEntity);
    }
}