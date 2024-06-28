using Application.DTOs.Response.Grade;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.GradeQuery
{
    public record GradeViewQuery(string? studentId) : IRequest<List<GradeView>>;
}
