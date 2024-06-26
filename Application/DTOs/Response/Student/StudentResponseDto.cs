using Domain.Const;

namespace Application.DTOs.Response.Student
{
    public record StudentResponseDto(string StudentId, string Name, Gender Gender, int ClassId, DateTime Dob, string Address); 
}
