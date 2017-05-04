using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MvcApp.ViewModel;

namespace MvcApp.Data
{
    public static class DbExtensions
    {
        public static void AddDatabaseData(this IApplicationBuilder app)
        {
            var factory = app.ApplicationServices.GetService<IServiceScopeFactory>();
            using (var scope = factory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<AppDbContext>();
                dbContext.AddRange(new Person
                {
                    Salutation = Salutation.Mr,
                    FirstName = "Albert",
                    LastName = "Weinert"
                }, new Person
                {
                    Salutation = Salutation.Mr,
                    FirstName = "Stefan",
                    LastName = "Lange"
                }, new Person
                {
                    Salutation = Salutation.Ms,
                    FirstName = "Melanie",
                    LastName = "Eibl"
                }, new Person
                {
                    Salutation = Salutation.Mr,
                    FirstName = "Roland",
                    LastName = "Weigelt"
                });
                dbContext.SaveChanges();
            }
        }
    }
}