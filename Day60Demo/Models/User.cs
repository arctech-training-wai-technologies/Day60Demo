﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Day60Demo.Models.Services.Validators;

namespace Day60Demo.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        [PreventBadWords(ErrorMessage = "Don't use bad language in Firstname")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        [PreventBadWords(ErrorMessage = "Don't use bad language. You will be reported to police")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        
        
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [Unicode(false)]
        public string Pan { get; set; }

        [StringLength(250)]
        [Unicode(false)]
        public string Address { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Gender { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string MobileNumber { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
        [Column(TypeName = "text")]
        public string Comment { get; set; }
        public int DepartmentRefId { get; set; }
        public double? Weight { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Password { get; set; }

        [ForeignKey("DepartmentRefId")]
        [InverseProperty("Users")]
        public virtual Department DepartmentRef { get; set; }
    }
}