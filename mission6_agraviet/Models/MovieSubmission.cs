﻿using System;
using System.ComponentModel.DataAnnotations;

namespace mission6_agraviet.Models
{
    public class MovieSubmission
    {
        [Key]
        [Required]
        public int submissionId { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }
    }
}