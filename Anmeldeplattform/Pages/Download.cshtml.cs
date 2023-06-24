using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace DNB_Frontend.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly IJSRuntime JsRuntime;

        public DownloadModel (IWebHostEnvironment env, IJSRuntime jSRuntime)
        {
            _env = env;
            this.JsRuntime = jSRuntime;
        }

        public IActionResult OnGet(string id, string path)
        {
            string[] files = Directory.GetFiles(Path.Combine(_env.WebRootPath, path));
                var filePath = Path.Combine(_env.WebRootPath, path, $"{path}_{id}.zip");
            this.JsRuntime.InvokeVoidAsync("console.log", filePath);
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                System.IO.File.Delete(filePath);

                return File(fileBytes, "application/force-download", $"{path}_" + DateTime.Now.ToString("dd.MM.yy") + ".zip");
            


        }
    }
}
