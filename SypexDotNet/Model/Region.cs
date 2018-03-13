namespace SypexDotNet.Model
{
    public class Region : BaseGeo
    {
        #region Constructors

        public Region(int id, decimal lat, decimal lon, string nameEn, string nameRu, string iso) : base(id, lat, lon, nameEn, nameRu)
        {
            Iso = iso;
        }

        #endregion

        #region Properties

        public string Country { get; set; }

        public string Iso { get; set; }

        public string Okato { get; set; }

        public string Timezone { get; set; }

        #endregion
    }
}
