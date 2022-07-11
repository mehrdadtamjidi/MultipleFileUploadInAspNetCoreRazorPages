using Microsoft.AspNetCore.Mvc.RazorPages;
using MultipleFileUploadInAspNetCoreRazorPages.Services.Interfaces;

namespace MultipleFileUploadInAspNetCoreRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFileUploadLocalService _fileUploadLocalService;

        public IndexModel(IFileUploadLocalService fileUploadLocalService)
        {
            _fileUploadLocalService = fileUploadLocalService;
        }

        public void OnGet()
        {

        }

        public void OnPost(IFormFile[] files)
        {
            var res = _fileUploadLocalService.UploadFile(files);

            ViewData["Message"] = "files uploaded!!";
        }
    }
}