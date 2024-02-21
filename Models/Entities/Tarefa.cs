using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ApiTarefaLogin.Models.Enums.Enums;

namespace ApiTarefaLogin.Models.Entities
{
    public class Tarefa
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(124)]
        public Guid LoginId { get; set; }
        public string Titulo { get; set; } = default!;
        [Required]
        [StringLength(500)]
        public string Descricao { get; set; } = default!;
        [Required]
        public DateTime DateStartTask { get; set;}
        [Required]
        public DateTime DateEndTask { get; set; }
        [Required]
        public StatusEnum Status { get; set; }
        public virtual Login Login { get; set; } = default!;
    }
}