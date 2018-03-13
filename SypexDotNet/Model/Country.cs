namespace SypexDotNet.Model
{
    public class Country : BaseGeo
    {
        #region Constructors

        public Country(int id, decimal lat, decimal lon, string nameEn, string nameRu, string iso) : base(id, lat, lon, nameEn, nameRu)
        {
            Iso = iso;
        }

        #endregion

        #region Properties

        public string Continent { get; set; }

        public string Iso { get; set; }

        public string Timezone { get; set; }

        #endregion
    }
}
