using Entidades;

namespace Services.ServMedicFIle
{
    public interface IMedicFile
    {
        Medicfile AddMediaFile(Medicfile mediaFile);
        List<Medicfile> AddMediaFiles();
    }

}
