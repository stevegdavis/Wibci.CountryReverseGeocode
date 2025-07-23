using System;
using System.Collections.Generic;
using System.Text;
using UnlockedData.CountryReverseGeocode.Models;

namespace UnlockedData.CountryReverseGeocode.Data
{
    public interface IReverseGeocodeDataProvider
    {
        List<AreaData> Data { get; }
     }
}
