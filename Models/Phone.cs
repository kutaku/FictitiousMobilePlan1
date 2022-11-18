using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FictitiousMobilePlan1.Models
{
	public class Phone
	{
		//POCO Plain Old Clr Object
		public int Id { get; set; }
		[DisplayName("プラン名")]
		public string PlanName { get; set; }
		[DisplayName("毎月の支払額")]
		public string Payment { get; set; }
		[DisplayName("姓")]
		public string Sei { get; set; }
		[DisplayName("名")]
		public string Mei { get; set; }
		[DisplayName("電話番号")]
		public string Tel { get; set; }
		[DisplayName("住所")]
		public string Address { get; set; }
		[DisplayName("契約開始日")]
		public DateTime Starttime { get; set; }
		[DisplayName("備考")]
		public string Remarks { get; set; } = String.Empty;
	}
}
