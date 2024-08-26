﻿using System.ComponentModel.DataAnnotations;

namespace CourseHub.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-Mail is required.")]
        public string? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName equired.")]

        public string? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName is required.")]

        public string? LastName { get; set; } = String.Empty;

        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
       
        public int? Age { get; set; }

        public string? SelectedCourse { get; set; } = String.Empty;

        public DateTime ApplyAt { get; set; }

       public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
