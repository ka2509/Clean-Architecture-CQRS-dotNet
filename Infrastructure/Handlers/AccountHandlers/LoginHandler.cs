using Application.DTOs.Response.Account;
using Application.Interfaces;
using Application.Queries.AccountQuery;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handlers.AccountHandlers
{
    public class LoginHandler : IRequestHandler<LoginAccountQuery, AccountResult>
    {
        private readonly ITokenService _tokenService;
        private readonly DataContext _context;
        public LoginHandler(ITokenService tokenService, DataContext context)
        {
            _tokenService = tokenService;
            _context = context;
        }

        public async Task<AccountResult> Handle(LoginAccountQuery request, CancellationToken cancellationToken)
        {
            var check = await _context.Students.Include(s => s.UserRoles).FirstOrDefaultAsync(s => s.StudentId == request.loginDto.StudentId);
            if (check == null) return new AccountResult(false, "Invalid StudenId!");
            var checkPass = BCrypt.Net.BCrypt.Verify(request.loginDto.Password, check.Password);
            if(checkPass)
            {
                return new AccountResult(true, _tokenService.CreateToken(check));
            }
            return new AccountResult(false, "Wrong Password!");
        }
    }
}
