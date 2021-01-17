using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orm2.Models
{
    [Table("exports")]
    public class Export
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("reporter")]
        public string? Reporter { get; set; }
        [Column("partner")]
        public string? Partner { get; set; }
        [Column("year")]
        public string? Year { get; set; }
        [Column("flow")]
        public string? Flow { get; set; }
        [Column("product_group")]
        public string? ProductGroup { get; set; }
        [Column("export_usd_thou")]
        public float? ExportUsdThou { get; set; }
        [Column("export_product_share_perc")]
        public float? ExportProductSharePerc { get; set; }
        [Column("rca")]
        public float? Rca { get; set; }
        [Column("world_growth")]
        public float? WorldGrowth { get; set; }
        [Column("country_growth")]        
        public float? CountryGrowth { get; set; }
    }
}
