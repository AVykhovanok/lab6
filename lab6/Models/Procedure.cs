using System.Collections.Generic;

namespace lab6.Models
{
    public class Procedure
    {
        public int ProcedureId { get; set; }
        public string ProcedureName { get; set; }

        public int ProcedurePrice { get; set; }

        public int PatientId { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }

    }
}
