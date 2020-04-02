﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    public class ProductItemRow
    {
        public int ItemId { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isDownload { get; set; }
        public bool isAvalivable { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}