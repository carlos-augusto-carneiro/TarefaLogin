using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefaLogin.Models.Entities
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(350)]
        public string Name { get; set; } = default!;
        [Required]
        [StringLength(250)]
        public string Email { get; set; } = default!;
        [Required]
        [StringLength(26)]
        public string Password { get; set; } = default!;

        public virtual ICollection<Tarefa> TarefaId { get; set; } = default!;
    }
}