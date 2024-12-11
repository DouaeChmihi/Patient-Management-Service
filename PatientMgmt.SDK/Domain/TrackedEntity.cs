namespace PatientMgmt.SDK.Domain;

public abstract class TrackedEntity<TPk> : EntityBase<TPk>
{
    public DateTime CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
}



//étendre le suivi des entités avec une gestion plus fine des dates de création et de mise à jour. Cela permet d'assurer que chaque entité est correctement audité, et il est souvent utilisé dans les applications où la traçabilité des changements est cruciale.