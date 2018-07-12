using System;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Services.Service;
using Airport_REST_API.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Airport_REST_API
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
            services.AddSingleton<DataSource>();
            services.AddTransient<ITicketService,TicketService>();
            services.AddTransient<IAircraftService, AircraftService>();
            services.AddTransient<IFlightService, FlightService>();
            services.AddTransient<IAircraftTypeService, AircraftTypeService>();
            services.AddSingleton<UnitOfWork>();
            var mapper = MapperConfiguration().CreateMapper();
            services.AddSingleton(_ => mapper);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TicketDTO,Ticket>();
                cfg.CreateMap<AircraftDTO, Aircraft>()
                    .ForMember(i => i.Type, opt => opt.Ignore())
                    .ForMember(i => i.Lifetime,opt => opt.MapFrom(m => DateTime.Now - DateTime.Parse(m.Lifetime)));
                cfg.CreateMap<PilotDTO, Pilot>();
                cfg.CreateMap<StewardessDTO, Stewardess>();
                cfg.CreateMap<AircraftTypeDTO, AircraftType>();
                cfg.CreateMap<FlightDTO, Flight>()
                    .ForMember(i => i.ArrivelTime, opt => opt.MapFrom(m => DateTime.Parse(m.ArrivelTime)));
                cfg.CreateMap<DeparturesDTO, Departures>()
                    .ForMember(i => i.Aircraft, opt => opt.Ignore())
                    .ForMember(i => i.Crew, opt => opt.Ignore())
                    .ForMember(i => i.DepartureTime, opt => opt.MapFrom(m => DateTime.Parse(m.DepartureTime)));
                cfg.CreateMap<CrewDTO, Crew>()
                    .ForMember(i => i.Stewardesses, opt => opt.Ignore())
                    .ForMember(i => i.Pilot, opt => opt.Ignore());

            });
            return config;
        }
    }
}
