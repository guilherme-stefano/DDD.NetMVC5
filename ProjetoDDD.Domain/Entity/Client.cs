using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectDDD.Domain.Entity
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

        public bool SpecialClient(Client client)
        {
            return client.Status && DateTime.Now.Year - client.DateCreated.Year >= 5;
        }
    }
}
