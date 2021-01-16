using WebUI.Domain;
using WebUI.ViewModels;

namespace WebUI.Services
{
	public interface IStudentService
	{
		public Student SaveStudent(StudentViewModel model);
	}
}