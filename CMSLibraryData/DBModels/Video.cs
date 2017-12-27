﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLibraryData.DBModels
{
    public class Video : CMSLibraryAsset
    {
        [Required]
        public string Director { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }
    }
}
