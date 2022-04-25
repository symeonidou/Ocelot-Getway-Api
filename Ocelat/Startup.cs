﻿using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Ocelat;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddOcelot();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        await app.UseOcelot();
    }
}