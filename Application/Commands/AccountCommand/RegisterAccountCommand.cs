using Application.DTOs;
using Application.DTOs.Request.Account;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.AccountCommand
{
    public record RegisterAccountCommand(RegisterDto RegisterDto) : IRequest<ServiceResponse>;
}
