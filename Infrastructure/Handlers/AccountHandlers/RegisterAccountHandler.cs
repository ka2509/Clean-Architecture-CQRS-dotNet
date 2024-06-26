using Application.Commands.AccountCommand;
using Application.DTOs;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handlers.AccountHandlers
{
    public class RegisterAccountHandler : IRequestHandler<RegisterAccountCommand, ServiceResponse>
    {
        private readonly DataContext _context;
        public RegisterAccountHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse> Handle(RegisterAccountCommand request, CancellationToken cancellationToken)
        {
            var check = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == request.RegisterDto.StudentId);
            if(check != null)
            {
                return new ServiceResponse(false, "Student already had an account!");
            }
            var registerDto = request.RegisterDto;
            await _context.AddAsync(new Student()
            {
                StudentId = registerDto.StudentId,
                Name = registerDto.Name,
                Gender = registerDto.Gender,
                ClassId = registerDto.ClassId,
                Dob = registerDto.Dob,
                Address = registerDto.Address,
                Password = BCrypt.Net.BCrypt.HashPassword(registerDto.Password),
            });
            await _context.SaveChangesAsync();
            return new ServiceResponse(true, "Account created successful!");
        }
    }
}
