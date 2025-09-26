namespace TF_HospitalDeApoyoDeCoraCora.Models
{
    public class Doctor
    {
        // Campos según la tabla ResponsableAtencion de la imagen
        public string? DNI { get; set; } // VARCHAR(8) - Primary Key
        public string? PrimerNombre { get; set; } // VARCHAR(20)
        public string? OtrosNombres { get; set; } // VARCHAR(20)
        public string? ApellidoPaterno { get; set; } // VARCHAR(20)
        public string? ApellidoMaterno { get; set; } // VARCHAR(20)
        public string? TipoResponsable { get; set; } // VARCHAR(30)
        public string? NumColegiatura { get; set; } // VARCHAR(5)
        public string? Especialidad { get; set; } // VARCHAR(30)

        // Campos adicionales que existían antes pero no están en la imagen
        public int Id { get; set; } // Campo ID original
        public string? Correo { get; set; } // Campo de correo original
        public string Contraseña { get; set; } = null!; // Campo de contraseña original
        public string? FotoUrl { get; set; } // Campo de foto original
        
        // Propiedades de compatibilidad
        public string? Nombre => PrimerNombre;
        public string? Apellido => $"{ApellidoPaterno} {ApellidoMaterno}".Trim();
    }
}