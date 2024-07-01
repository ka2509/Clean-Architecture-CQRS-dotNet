using Application.DTOs.Response.Class;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.ClassQuery
{
    public record ClassViewQuery : IRequest<List<ClassView>>;
}
