using System;
using System.Linq;
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
            services.AddSingleton<ITicketService,TicketService>();
            services.AddSingleton<IAircraftService, AircraftService>();
            services.AddSingleton<IFlightService, FlightService>();
            services.AddSingleton<IAircraftTypeService, AircraftTypeService>();
            services.AddSingleton<ICrewService, CrewService>();
            services.AddSingleton<IStewardessService, StewardessService>();
            services.AddSingleton<IPilotService, PilotService>();
            services.AddSingleton<IDepartureService,DepartureService>();
            services.AddSingleton<IUnitOfWork,UnitOfWork>();
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
                //Into Model
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
                //Into DTO
                cfg.CreateMap<Ticket,TicketDTO>();
                cfg.CreateMap<Aircraft, AircraftDTO>()
                    .ForMember(i => i.ReleseDate, opt => opt.MapFrom(m => m.ReleseDate.ToShortDateString()))
                    .ForMember(i => i.Lifetime, opt => opt.MapFrom(m => m.Lifetime.TotalDays));
                cfg.CreateMap<Pilot, PilotDTO>();
                cfg.CreateMap<Stewardess, StewardessDTO>();
                cfg.CreateMap<AircraftType, AircraftTypeDTO>();
                cfg.CreateMap<Flight, FlightDTO>()
                    .ForMember(i => i.ArrivelTime, opt => opt.MapFrom(m => m.ArrivelTime.ToLongDateString()))
                    .ForMember(i => i.DepartureTime, opt => opt.MapFrom(m => m.DepartureTime.ToLongDateString()))
                    .ForMember(i => i.TicketsId, opt => opt.MapFrom(m => m.Ticket.Select(s => s.Id)));
                cfg.CreateMap<Departures, DeparturesDTO>()
                    .ForMember(i => i.AircraftId, opt => opt.MapFrom(m => m.Aircraft.Id))
                    .ForMember(i => i.CrewId, opt => opt.MapFrom(m => m.Crew.Id))
                    .ForMember(i => i.DepartureTime, opt => opt.MapFrom(m => m.DepartureTime.ToShortDateString()));
                cfg.CreateMap<Crew, CrewDTO>()
                    .ForMember(i => i.StewardessesId, opt => opt.MapFrom(m => m.Stewardesses.Select(s => s.Id)))
                    .ForMember(i => i.PilotId, opt => opt.MapFrom(m => m.Pilot.Id));

            });
            return config;
        }
    }
}
