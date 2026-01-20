using Wibci.CountryReverseGeocode.Models;
using Wibci.CountryReverseGeocode;
namespace XUnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var countryService = new CountryReverseGeocodeService();
        var location = new GeoLocation()
        {
            Latitude = 51.745564,
            Longitude = -2.218266

        };
        var locationNeth = new GeoLocation()
        {
            Latitude = 53.368723,//Netherlands
            Longitude = 5.216398
        };

        var country = countryService.FindCountry(location);
        
        Console.WriteLine(country.Name);
    }
}
