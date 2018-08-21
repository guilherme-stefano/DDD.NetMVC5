using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDDD.Domain.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int Value { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
