namespace SypexDotNet.Model
{
    public class City : BaseGeo
    {
        #region Constructors

        public City(int id, decimal lat, decimal lon, string nameEn, string nameRu) : base(id, lat, lon, nameEn, nameRu)
        {
        }

        #endregion

        #region Properties

        public string Okato { get; set; }

        public int RegionId { get; set; }

        #endregion
    }
}
