using System;

namespace MShared
{
    public interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}
