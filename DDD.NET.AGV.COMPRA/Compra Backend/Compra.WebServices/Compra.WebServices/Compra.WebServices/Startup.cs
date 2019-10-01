using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace AgvCompra.WebServices
{
    /// <summary>
    /// Inicio de programa, llamado a controladores
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //Representa un conjunto de propiedades de configuración de la aplicación clave / valor. Interface
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// Este método es llamado en tiempo de ejecución. Use este método para agregar servicios al contenedor
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => {
                    var resolver = options.SerializerSettings.ContractResolver;
                    if (resolver != null) (resolver as DefaultContractResolver).NamingStrategy = null;
                });
            ///Se enlaza un contexto de conexion a un context que queremos
            services.Configure<ConnectionContext>(Configuration.GetSection("ConnectionContext"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Este método es llamado en tiempo de ejecución. Use este método para configurar la canalización de solicitudes HTTP
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            ///Permitir al frond consumir las apis -- Allow frond to consume apis
            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());

            //app.UseMvcWithDefaultRoute();

            ///configiración de rutas -- route settings
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
