using Application.DTOs.Request.Account;
using Application.DTOs.Response.Account;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.AccountQuery
{
    public record LoginAccountQuery(LoginDto loginDto) : IRequest<AccountResult>;
}
