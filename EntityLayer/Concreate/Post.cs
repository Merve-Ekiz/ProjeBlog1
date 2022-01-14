using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostCaption { get; set; }
        public string PostContent { get; set; }
        public bool PostStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime PublishDate { get; set; }
        public string image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
