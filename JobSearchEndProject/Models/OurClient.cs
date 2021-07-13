using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsyJob.Models
{
    public class OurClient
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
