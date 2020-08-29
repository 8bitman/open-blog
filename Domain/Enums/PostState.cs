using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum PostState
    {
        [Display(Name = "Oculto")]
        Hidden,
        
        [Display(Name = "Publicado")]
        Published
    }
}