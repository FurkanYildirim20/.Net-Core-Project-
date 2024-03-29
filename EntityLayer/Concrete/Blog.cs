﻿using CoreLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ThumbNail { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
