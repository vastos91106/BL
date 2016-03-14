using Core.Entities;

namespace Domain.Implementation
{
    public interface IByPassState
    {
        bool UpdateByPassState(ByPassState byPassStateEntity);
    }
}