namespace TF_HospitalDeApoyoDeCoraCora.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
    }
}
