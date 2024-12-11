
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PatientMgmt.SDK.Domain
{
    [Serializable]
    public abstract class EntityBase<TPk>
    {
        //Généricité (TPk) : Permet une flexibilité pour utiliser différents types d'identifiants (Guid, int, string, etc.).
        [Key]
        public TPk Id { get; set; }

        //Pratique pour implémenter une suppression logique (soft delete) au lieu d'une suppression physique.
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        //Fournit une manière élégante de visualiser les propriétés d'une entité pour le débogage ou le logging.
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
