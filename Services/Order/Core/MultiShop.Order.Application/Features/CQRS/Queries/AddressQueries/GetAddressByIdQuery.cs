using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery
    {
        public int Id { get; set; } //bunu controller da ctor üzerinden çağırıcaz
        public GetAddressByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
