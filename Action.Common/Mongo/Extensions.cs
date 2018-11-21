using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace Action.Common.Mongo
{
    public static class Extensions
    {
        public static void AddMongoDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoOptions>(options=>configuration.GetSection("mongo").Bind(options));
            services.AddSingleton<MongoClient>(c =>
            {
                var option = c.GetService<IOptions<MongoOptions>>();
                return new MongoClient(option.Value.ConnectionString);
            });

            services.AddSingleton<IMongoDatabase>(c =>
            {
                var options = c.GetService<IOptions<MongoOptions>>();
                var client = c.GetService<MongoClient>();
                return client.GetDatabase(options.Value.Database);
            });
        }

    }
}
