using System.ComponentModel.DataAnnotations.Schema;

namespace Hovani.Models
{
    public class ClientModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("phone")]
        public string phone { get; set; }
        [Column("isRegular")]
        private bool isRegular { get; set; }
        private int visitings { get; set; }
    }
}
