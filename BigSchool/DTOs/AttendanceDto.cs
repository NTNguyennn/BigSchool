using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.DTOs
{
    public class AttendanceDto
    {
        public int CourseId { get; set; }
    }
}