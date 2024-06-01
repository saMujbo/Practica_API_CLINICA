using Entidades;
using Services.MyDbContext;


namespace Services.ServMedicFIle
{
    public  class SvMedicFile : IMedicFile
    {
        private MyContext _myDbecontext = default!;

        public SvMedicFile()
        {
            _myDbecontext = new MyContext();
        }
        public Medicfile AddMediaFile(Medicfile mediaFile)
        {
            _myDbecontext.MedicFiles.Add(mediaFile);
            return mediaFile;
        }

        public List<Medicfile> AddMediaFiles()
        {
           return _myDbecontext.MedicFiles.ToList();
        }
    }
}
