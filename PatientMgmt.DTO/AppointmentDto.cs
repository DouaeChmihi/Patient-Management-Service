namespace PatientMgmt.DTO
{
    public class AppointmentDto
    {
        // Unique identifier for the appointment
        public int Id { get; set; }

        // ID of the patient for the appointment
        public int PatientId { get; set; }

        // ID of the doctor for the appointment
        public int DoctorId { get; set; }

        // Start time of the appointment
        public DateTime StartTime { get; set; }

        // End time of the appointment
        public DateTime EndTime { get; set; }

        // Notes or additional information about the appointment
        public string? Notes { get; set; }

        // Status of the appointment (e.g., Scheduled, Completed, Cancelled)
        public string Status { get; set; } = "Scheduled";

    }
}
