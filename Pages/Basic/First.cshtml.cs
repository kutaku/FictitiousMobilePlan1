using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FictitiousMobilePlan1.Pages.Basic
{
    public class FirstModel : PageModel
    {
        //�e���v���[�g�ŗ��p������
       public string Message { get; set; }
        //�y�[�W�N�����̏���
        public IActionResult OnGet()
        {
            //d.�v���p�e�B�ɒl�����蓖�Ă�
            Message = "�ˋ�̌g�щ�Џ��";
            return Page();
        }
    }
}
