using System.Data.Entity;

namespace lab6.Models
{
    public class Procedures_Dbnitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            db.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureName = "Cataract surgery", ProcedurePrice = 1300 });
            db.Procedures.Add(new Procedure { ProcedureId = 2, ProcedureName = "Mastectomy", ProcedurePrice = 800 });
            db.Procedures.Add(new Procedure { ProcedureId = 3, ProcedureName = "Tonsillectomy", ProcedurePrice = 500 });

            base.Seed(db);
        }
    }
}

