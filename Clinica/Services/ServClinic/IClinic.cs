using Entidades;

namespace Services.ServClinic
{
    public  interface IClinic
    {
        public Clinic AddCLinic(Clinic clinic);
        public List<Clinic> GetAllClinics();
    }
}
