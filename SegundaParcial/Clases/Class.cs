using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models
{
    public class Product
    {
        public int InventoryNumber { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(200, ErrorMessage = "El nombre no puede exceder los 200 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        public string Department { get; set; }
    }
}
