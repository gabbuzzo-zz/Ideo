using Ideo.Backend.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Ideo.Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
                //.AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options => Configuration.Bind("JwtSettings", options))
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options => Configuration.Bind("CookieSettings", options));
            //Add Protection
            #region certificato x509
            //services.AddDataProtection()
            //.PersistKeysToFileSystem(new DirectoryInfo(@"\\server\share\directory\"))
            //.ProtectKeysWithCertificate(
            //new X509Certificate2("certificate.pfx", Configuration["Thumbprint"]))
            //.UnprotectKeysWithAnyCertificate(
            //new X509Certificate2("certificate_old_1.pfx", Configuration["MyPasswordKey_1"]),
            //new X509Certificate2("certificate_old_2.pfx", Configuration["MyPasswordKey_2"]));

            #endregion
            #region Critto
            //AddDataProtection riguardante la crittografia di default usata per le password
            //services.AddDataProtection()
            //.UseCryptographicAlgorithms(
            // new AuthenticatedEncryptorConfiguration()
            //{
            //    EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
            //    ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
            //});
            #endregion
            //services.AddDataProtection()
            //.PersistKeysToDbContext<IdeoBackendContext>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ideo.Backend", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ideo.Backend v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
