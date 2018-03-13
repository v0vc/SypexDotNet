namespace SypexDotNet.Model
{
    public abstract class BaseGeo
    {
        #region Constructors

        protected BaseGeo(int id, decimal lat, decimal lon, string nameEn, string nameRu)
        {
            Id = id;
            Lat = lat;
            Lon = lon;
            NameEn = nameEn;
            NameRu = nameRu;
        }

        #endregion

        #region Properties

        public int Id { get; set; }

        public decimal Lat { get; set; }

        public decimal Lon { get; set; }

        public string NameEn { get; set; }

        public string NameRu { get; set; }

        #endregion
    }
}
