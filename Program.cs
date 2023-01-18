using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Estudos_EntityFrameork.Infrastructure.DataAcess;
using System.Data.SqlClient;

namespace Estudos_EntityFrameork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceCollection services = new ServiceCollection();


            ///<summary>
            ///
            /// WHEN DO YOU USE SCOPED ? 
            /// Method registers the service with a scopt lifetime, the lifetime of a single request.
            /// 
            /// </summary>

            services.AddDbContext<EstudosDbContext>(opt => 
            {
                string connectionString = new SqlConnectionStringBuilder("localhost://1433").ConnectionString;

                opt.UseSqlServer
            });

            

        }
    }
}
