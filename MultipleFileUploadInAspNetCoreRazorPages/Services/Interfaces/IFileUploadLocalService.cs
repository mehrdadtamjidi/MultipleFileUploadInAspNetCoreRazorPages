namespace MultipleFileUploadInAspNetCoreRazorPages.Services.Interfaces
{
    public interface IFileUploadLocalService
    {
        Task<bool> UploadFile(IFormFile[] files);
    }
}
