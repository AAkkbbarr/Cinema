using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BaseEntity
    {
        public Guid Id { get; init; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
