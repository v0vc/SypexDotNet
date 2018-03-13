using SypexDotNet.Model;

namespace SypexDotNet
{
    public interface IReader
    {
        #region Methods

        SypexResponse GetLocation(string ip, bool isDetailed);

        #endregion
    }
}
