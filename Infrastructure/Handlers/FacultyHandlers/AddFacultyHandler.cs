using Application.Commands.FacultyCommand;
using Application.DTOs;
using Application.DTOs.Request;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers.FacultyHandlers
{
    public class AddFacultyHandler : IRequestHandler<AddFacultyCommand, ServiceResponse>
    {
        private readonly DataContext _context;
        public AddFacultyHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse> Handle(AddFacultyCommand request, CancellationToken cancellationToken)
        {
            var check = await _context.Faculties.FirstOrDefaultAsync(f => f.Name.ToLower() == request.FacultyDto.Name.ToLower());
            if (check != null)
            {
                return new ServiceResponse(false, "Falcuty already exist!");
            }
            var facultyModel = new Faculty { Name = request.FacultyDto.Name };

            await _context.Faculties.AddAsync(facultyModel);
            await _context.SaveChangesAsync(cancellationToken);
            return new ServiceResponse(true, "Create faculty sucessful!");
        }
    }
}
