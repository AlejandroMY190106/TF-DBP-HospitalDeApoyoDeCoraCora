namespace TF_HospitalDeApoyoDeCoraCora.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        
        // Datos de identificación
        public string? TipoDocumento { get; set; } // DNI, CE, Pasaporte
        public string? NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        // Nombres y apellidos
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Nombres { get; set; }
        
        // Datos personales
        public string? Sexo { get; set; } // M, F, O
        public string? EstadoCivil { get; set; } // Soltero, Casado, Divorciado, Viudo
        
        // Contacto
        public string? Celular { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Anexo { get; set; }
        public string? Correo { get; set; }
        
        // Ubicación
        public string? Departamento { get; set; }
        public string? Provincia { get; set; }
        public string? Distrito { get; set; }
        
        // Credenciales
        public string? Contraseña { get; set; }
        
        // Propiedades de compatibilidad (por si se usan en otras partes)
        public string? Apellido => $"{ApellidoPaterno} {ApellidoMaterno}".Trim();

    }
}
