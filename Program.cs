using Mapeamento.Mapping;

var request = new CreateStudentRequest
{
    FirstName = "yuri"
};

var student = request;

var student2 = request.MapToStudent();

var text = "yuri,Alexander,Nobre,de,melo".MaptoArray();


Console.WriteLine($"Estudante 1: {student.FirstName} e Estudante 2: {student2.FirstName}");

foreach (string textItem in text)
{
    Console.WriteLine( textItem );
} 
