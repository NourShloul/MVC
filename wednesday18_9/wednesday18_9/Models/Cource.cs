﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wednesday18_9.Models
{
    public class Cource
    {
        [Key, Column(Order = 0)] // First part of the composite key
        public int CourseId { get; set; }

        [Column(Order = 1)] // Second part of the composite key
        public int TeacherId { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }
    }
}