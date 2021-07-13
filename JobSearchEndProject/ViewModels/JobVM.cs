using EsyJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsyJob.ViewModels
{
    public class JobVM
    {
        public List<Job> Jobs{ get; set; }
        public List<Category> Categories { get; set; }
    }
}
