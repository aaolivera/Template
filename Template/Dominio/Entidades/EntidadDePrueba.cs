using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class EntidadDePrueba
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Usuario { get; set; }

    }
}
