﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FA.JustBlog.Core.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "CateId")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string UrlSlug { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}
