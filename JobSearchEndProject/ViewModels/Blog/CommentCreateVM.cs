using EsyJob.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsyJob.ViewModels
{
    public class CommentCreateVM
    {
        public string Message { get; set; }
        public int BlogId { get; set; }
    }
}
