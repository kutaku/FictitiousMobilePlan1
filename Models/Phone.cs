using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FictitiousMobilePlan1.Models
{
	public class Phone
	{
		//POCO Plain Old Clr Object
		public int Id { get; set; }
		[DisplayName("プラン名")]
		[Required(ErrorMessage = "{0}は必須です。")]
		public string PlanName { get; set; }
		[DisplayName("毎月の支払額")]
		[Range(0,50000,ErrorMessage = "{0}は{1}~{2}円以内で入力してください。")]
		[DataType(DataType.Currency)]
		public int Payment { get; set; }
		[DisplayName("姓")]
		[StringLength(20, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
		public string Sei { get; set; }
		[DisplayName("名")]
		[StringLength(20, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
		public string Mei { get; set; }
		[DisplayName("電話番号")]
		[Range(0, 11, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
		public string Tel { get; set; }
		[DisplayName("住所")]
		[StringLength(50, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
		public string Address { get; set; }
		[DisplayName("契約開始日")]
		public DateTime Starttime { get; set; }
		[DisplayName("備考")]
		[StringLength(100, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
		public string Remarks { get; set; } = String.Empty;
	}
}
