﻿
using HuynhMinhTuan_Lab456.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HuynhMinhTuan_Lab456.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

        public static implicit operator DateTime(CourseViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
