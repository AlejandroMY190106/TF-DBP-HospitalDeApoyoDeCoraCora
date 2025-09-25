namespace TF_HospitalDeApoyoDeCoraCora.Models
{
    public class FUA
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public DateTime FechaAtencion { get; set; }
    }
}
