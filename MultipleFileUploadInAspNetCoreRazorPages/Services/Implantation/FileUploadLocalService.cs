using MultipleFileUploadInAspNetCoreRazorPages.Services.Interfaces;

namespace MultipleFileUploadInAspNetCoreRazorPages.Services.Implantation
{
    public class FileUploadLocalService : IFileUploadLocalService
    {
        private IWebHostEnvironment _environment;
        public FileUploadLocalService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task<bool> UploadFile(IFormFile[] files)
        {
            string path = "";
            try
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        path = Path.GetFullPath(Path.Combine(_environment.WebRootPath, "UploadedFiles"));
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
