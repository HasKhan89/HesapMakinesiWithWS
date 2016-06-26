using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiWithWS
{
    public class CalculatorContext : DbContext
    {
        public DbSet<CalculatorIslem> CalculatorIslemler { get; set; }
    }

    [Table("CalculatorIslemler")]
    public class CalculatorIslem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? IslemTarihi { get; set; }

        public int? Sayi1 { get; set; }
        public int? Sayi2 { get; set; }
        public int? Sonuc { get; set; }

        [Required, StringLength(10)]
        public string IslemTuru { get; set; }
    }
}
