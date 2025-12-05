using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomiodMiddleware.Models
{
    public class ContentInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string contentType { get; set; }
        public string content { get; set; }
        public DateTime Created_at { get; set; }
    }
}