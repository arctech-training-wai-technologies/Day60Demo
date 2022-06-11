﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Day60Demo.Models
{
    [Table("Book", Schema = "library")]
    [Index("AuthorRefId", Name = "IX_Book_AuthorRefId")]
    public partial class Book
    {
        [Key]
        [StringLength(13)]
        public string Isbn { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "date")]
        public DateTime LaunchDate { get; set; }
        public int AuthorRefId { get; set; }

        [ForeignKey("AuthorRefId")]
        [InverseProperty("Books")]
        public virtual Author AuthorRef { get; set; }
    }
}