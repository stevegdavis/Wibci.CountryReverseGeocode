using UnlockedData.CountryReverseGeocode.Models;
using UnlockedData.CountryReverseGeocode;
namespace XUnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var countryService = new CountryReverseGeocodeService();
        var location = new GeoLocation()
        {
            Latitude = 49.007858265297706,
           


            Longitude = -123.06867315982991

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
