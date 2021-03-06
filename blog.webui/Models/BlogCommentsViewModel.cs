﻿using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class BlogCommentsViewModel
    {
        public Blog Blog { get; set; }
        public List<Comment> GetCommentByUrl { get; set; }
        public Comment NewComment { get; set; }
    }
}
