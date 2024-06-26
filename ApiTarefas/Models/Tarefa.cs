using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiTarefas.Models
{
    [Table("tarefas")]


    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;
        
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = default!;

        [Column(TypeName ="text")]
        public string Descricao { get; set; } = default!;
        
        public bool Concluida { get; set; } = default!;
        
    }
}