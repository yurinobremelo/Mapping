using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeamento.Mapping
{
    public static class StudentExtension
    {
        public static Student MapToStudent (this CreateStudentRequest request)
        {
            return new Student
            {
                Id = 0,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Phone = request.Phone,
                PostalCode = request.PostalCode,
                Country = request.Country,
                IsActive = request.IsActive,
                CreatedAt = request.CreatedAt
            };
        }
    }
}
