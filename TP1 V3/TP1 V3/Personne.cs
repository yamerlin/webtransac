using System.ComponentModel.DataAnnotations;

public class Personne
{
    [Required]
    public string Nom { get; set; }

    [Required]
    [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+[.][a-zA-Z0-9.-]+$", ErrorMessage = "Entrez un couriel valide s'il vous plait")]
    public string Couriel { get; set; }

    [Required]
    public string Adresse { get; set; }

    [Required]
    [RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d", ErrorMessage = "Entrez un code postale valide s'il vous plait")]
    public string CodePostale { get; set; }

    [Required]
    public string Couleur { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public bool Celibataire { get; set; }

    public string Celibat { get; set; }
}
