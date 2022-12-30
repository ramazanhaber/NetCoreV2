using System.ComponentModel.DataAnnotations;

namespace NetCoreV2.DataAccesLayer
{
    public class Ogrenci
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public int yas { get; set; }
    }
}
