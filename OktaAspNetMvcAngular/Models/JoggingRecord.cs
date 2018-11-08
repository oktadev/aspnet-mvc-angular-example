using System;

namespace OktaAspNetMvcAngular.Models
{
    public class JoggingRecord
    {
        public int Id { get; set; }

        public float Distance { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}