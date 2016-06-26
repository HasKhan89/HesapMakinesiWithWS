using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoListWebApp
{
    public class TodoListContext : DbContext
    {
        public DbSet<Gorev> Gorevler { get; set; }
    }

    [Table("Gorevler")]
    public class Gorev
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [Required, StringLength(200)]
        public string Task { get; set; }

        public bool IsCompleted { get; set; }
    }
}