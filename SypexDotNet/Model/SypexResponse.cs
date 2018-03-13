namespace SypexDotNet.Model
{
    public class SypexResponse
    {
        #region Constructors

        public SypexResponse(string ip,
            int cityId,
            int countryId,
            int regionId,
            decimal cityLat,
            decimal countryLat,
            decimal regionLat,
            decimal cityLon,
            decimal countryLon,
            decimal regionLon,
            string cityNameEn,
            string countryNameEn,
            string regionNameEn,
            string cityNameRu,
            string countryNameRu,
            string regionNameRu,
            string countryIso,
            string regionIso)
        {
            Ip = ip;
            City = new City(cityId, cityLat, cityLon, cityNameEn, cityNameRu);
            Country = new Country(countryId, countryLat, countryLon, countryNameEn, countryNameRu, countryIso);
            Region = new Region(regionId, regionLat, regionLon, regionNameEn, regionNameRu, regionIso);
        }

        #endregion

        #region Properties

        public City City { get; set; }

        public Country Country { get; set; }

        public string Ip { get; set; }

        public Region Region { get; set; }

        #endregion

        #region Static Methods

        public static SypexResponse CreateDefaultModel(string ip)
        {
            return new SypexResponse(ip,
                524901,
                185,
                524894,
                55,
                60,
                55,
                37,
                100,
                37,
                "Moscow",
                "Russia",
                "Moskva",
                "Москва",
                "Россия",
                "Москва",
                "RU",
                "RU-MOW");
        }

        #endregion
    }
}
