using System.ComponentModel.DataAnnotations;

namespace CompanyCrudBlazor.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
		[Required(ErrorMessage = "O campo site é obrigatório.")]
		[RegularExpression(@"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$", ErrorMessage = "O campo site deve ser uma URL válida.")]
		public string Site { get; set; }
		[Required]
		public EnumSegment Segment { get; set; }



        public void GenerateNewId()
        {
            Id = Guid.NewGuid();    
        }


    }
}
