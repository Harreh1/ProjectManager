using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public enum CategoryNames
    {
        ToDo,
        InProgress,
        Finished
    }

    public class TaskDetail
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string TaskTitle { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string TaskDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }
        [Required]
        public CategoryNames Category { get; set; }
        
    }
}
