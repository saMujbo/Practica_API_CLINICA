
using Entidades;
using Services.MyDbContext;
using Services.ServMedicFIle;

namespace Services.ServClinic
{
    public class SvClinic : IClinic
    {
        private MyContext _Dbcontext = default!;
        public SvClinic() {

            _Dbcontext = new MyContext();   
        }

        public Clinic AddCLinic(Clinic clinic)
        {
            _Dbcontext.Clinics.Add(clinic);
            _Dbcontext.SaveChanges();
            return clinic;
        }

        public List<Clinic> GetAllClinics()
        {
            return _Dbcontext.Clinics.ToList();
        }
    }
}
