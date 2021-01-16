using WebUI.Domain;
using WebUI.ViewModels;

namespace WebUI.Services
{
	public class StudentService : IStudentService
	{
		private readonly IFileUploadService _fileUploadService;

		public StudentService(IFileUploadService fileUploadService)
		{
			_fileUploadService = fileUploadService;
		}

		public Student SaveStudent(StudentViewModel model)
		{
			var filePath = _fileUploadService.UploadFile(model.File);

			var student = new Student
			{
				Name = model.Name,
				ImagePath = filePath
			};

			// Save student to database

			return student;
		}
	}
}