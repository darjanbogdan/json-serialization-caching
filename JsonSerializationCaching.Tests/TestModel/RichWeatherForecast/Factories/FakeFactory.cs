﻿namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public abstract class FakeFactory<TFactory, TData> 
        where TFactory : class, new()
        where TData : class
    {
        private static readonly TFactory instance = new TFactory();

        public static TFactory Instance
        {
            get { return instance; }
        }

        public abstract TData CreateFakeItem(int id);
    }
}