using CqrsMediatR.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatR.Commands
{
    public class AddProductCommand : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}
