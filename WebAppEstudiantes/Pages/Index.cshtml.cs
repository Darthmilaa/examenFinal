using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppEstudiantes.Data;
using WebAppEstudiantes.Models;

namespace WebAppEstudiantes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
            EstudiantesList = new List<Estudiante>(); // Inicialización predeterminada
        }

        public IList<Estudiante> EstudiantesList { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                EstudiantesList = await _context.Estudiantes.ToListAsync();
            }
            catch
            {
                // Manejo de errores sin detalles específicos
                ViewData["ErrorMessage"] = "Ocurrió un error al intentar obtener los datos. Inténtalo de nuevo más tarde.";
            }
        }
    }
}
