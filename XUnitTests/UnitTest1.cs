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
            Latitude = 51.00,
            Longitude = 0
        };

        var country = countryService.FindCountry(location);
        
        Console.WriteLine(country.Name);;
    }
}
