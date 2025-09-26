using System;
using System.Collections.Generic;

namespace TF_HospitalDeApoyoDeCoraCora.Models
{
    public class FUA
    {
        // SECCIÓN: ENCABEZADO Y DATOS DE LA IPRESS
    public string? NumeroFormato { get; set; }
    public string? CodigoRenipressIpress { get; set; }
    public string? NombreIpress { get; set; }

        // SECCIÓN: LUGAR Y TIPO DE ATENCIÓN
    public string? LugarAtencion { get; set; } // Intramural, Extramural
    public string? TipoAtencion { get; set; } // Ambulatoria, Emergencia, Referencia
        
        // SECCIÓN: REFERENCIA (si aplica)
    public string? CodigoRenipressReferencia { get; set; }
    public string? NombreIpressReferencia { get; set; }
    public string? NumeroHojaReferencia { get; set; }

        // SECCIÓN: DEL ASEGURADO
        public int PacienteId { get; set; } // Mantenemos la relación
    public string? ApellidoPaterno { get; set; }
    public string? ApellidoMaterno { get; set; }
    public string? PrimerNombre { get; set; }
    public string? OtrosNombres { get; set; }
    public string? Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    public string? Etnia { get; set; }
    public string? NumeroHistoriaClinica { get; set; }
    public string? CodigoAseguradoSIS { get; set; }

        // SECCIÓN: SALUD MATERNA (si aplica)
        public bool EsGestante { get; set; }
        public bool EsPuerpera { get; set; }
        public DateTime? FechaProbableParto { get; set; }
        public DateTime? FechaParto { get; set; }
        
        // SECCIÓN: DE LA ATENCIÓN
        public DateTime FechaAtencion { get; set; }
        public TimeSpan HoraAtencion { get; set; }
    public string? CodigoUPS { get; set; }
    public string? CodigoPrestacion { get; set; }

        // SECCIÓN: DESTINO DEL ASEGURADO
    public string? DestinoAsegurado { get; set; } // Alta, Cita, Referido, etc.

        // Clase separada para Diagnostico
    public string? DiagnosticoPrincipal { get; set; }
    public string? Cie10Ingreso { get; set; }
    public string? Cie10Egreso { get; set; }

    public string? Tratamiento { get; set; }

        // SECCIÓN: RESPONSABLE DE LA ATENCIÓN
    public int DoctorId { get; set; } // Mantenemos la relación
    public string? NombreResponsable { get; set; }
    public string? Colegiatura { get; set; }
    public string? Especialidad { get; set; }
    }
}