using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FictitiousMobilePlan1.Pages.Basic
{
    public class FirstModel : PageModel
    {
        //テンプレートで利用する情報
       public string Message { get; set; }
        //ページ起動時の処理
        public IActionResult OnGet()
        {
            //d.プロパティに値を割り当てる
            Message = "架空の携帯会社情報";
            return Page();
        }
    }
}
