using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public interface IFakeIdentityItemFactory<T> where T : class
    {
        T CreateFakeItem(int id);
    }
}
