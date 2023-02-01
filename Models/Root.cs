using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion4.Models
{
    public class Root
    {
        public string status { get; set; }
        public string download_url { get; set; }
        public string download_url_png { get; set; }
        public string template_id { get; set; }
        public string transaction_ref { get; set; }
        public List<PostAction> post_actions { get; set; }
    }

    public class PostAction
    {
        public string action { get; set; }
        public string name { get; set; }
        public string bucket { get; set; }
        public string status { get; set; }
        public string file { get; set; }
    }
}
