using Microsoft.AspNetCore.Http;

namespace WebUI.Services
{
	public interface IFileUploadService
	{
		public string UploadFile(IFormFile file);
	}
}