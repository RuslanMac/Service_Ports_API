using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication14
{
    public partial class World_Ports_DBContext : DbContext
    {
        public World_Ports_DBContext()
        {
        }

        public World_Ports_DBContext(DbContextOptions<World_Ports_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GetPortsColumnsSpecial> GetPortsColumnsSpecials { get; set; }
        public virtual DbSet<ResultsPortInformation> ResultsPortInformations { get; set; }
        public virtual DbSet<ThePort> ThePorts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-19PT7TH;Database=World_Ports_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<GetPortsColumnsSpecial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetPortsColumnsSpecial");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.IndexNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("index_number");

                entity.Property(e => e.PortLatitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_latitude");

                entity.Property(e => e.PortLongitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_longitude");

                entity.Property(e => e.PortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_name");
            });

            modelBuilder.Entity<ResultsPortInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("results_port_information");

                entity.Property(e => e.AnchorageDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anchorage_depth");

                entity.Property(e => e.CargoAnchor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_anchor");

                entity.Property(e => e.CargoBeachMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_beach_moor");

                entity.Property(e => e.CargoIceMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_ice_moor");

                entity.Property(e => e.CargoMedMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_med_moor");

                entity.Property(e => e.CargoOilDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_oil_depth");

                entity.Property(e => e.CargoPierDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_pier_depth");

                entity.Property(e => e.CargoWharf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_wharf");

                entity.Property(e => e.ChannelDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("channel_depth");

                entity.Property(e => e.ChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chart_number");

                entity.Property(e => e.CommsAir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_air");

                entity.Property(e => e.CommsFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_fax");

                entity.Property(e => e.CommsPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_phone");

                entity.Property(e => e.CommsRadio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_radio");

                entity.Property(e => e.CommsRail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_rail");

                entity.Property(e => e.CommsVhf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_vhf");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CraneFixed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_fixed");

                entity.Property(e => e.CraneFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_float");

                entity.Property(e => e.CraneMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_mobile");

                entity.Property(e => e.DeckSupplies)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deck_supplies");

                entity.Property(e => e.Degauss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("degauss");

                entity.Property(e => e.Diesel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("diesel");

                entity.Property(e => e.DirtyBallast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dirty_ballast");

                entity.Property(e => e.DryDockTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dry_dock_types");

                entity.Property(e => e.EngSupplies)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eng_supplies");

                entity.Property(e => e.EntryIce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_ice");

                entity.Property(e => e.EntryOther)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_other");

                entity.Property(e => e.EntrySwell)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_swell");

                entity.Property(e => e.EntryTide)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_tide");

                entity.Property(e => e.EtaMessageRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eta_message_required");

                entity.Property(e => e.FuelOil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fuel_oil");

                entity.Property(e => e.GarbageDispose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("garbage_dispose");

                entity.Property(e => e.GoodHoldingGround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("good_holding_ground");

                entity.Property(e => e.HarborSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("harbor_size");

                entity.Property(e => e.HarborType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("harbor_type");

                entity.Property(e => e.IndexNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("index_number");

                entity.Property(e => e.Lift024Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_0_24_tons");

                entity.Property(e => e.Lift100Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_100_tons");

                entity.Property(e => e.Lift2549Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_25_49_tons");

                entity.Property(e => e.Lift50100Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_50_100_tons");

                entity.Property(e => e.MaxVesselSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("max_vessel_size");

                entity.Property(e => e.MedFacility)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("med_facility");

                entity.Property(e => e.OverheadLimit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("overhead_limit");

                entity.Property(e => e.PilotAdvised)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_advised");

                entity.Property(e => e.PilotAvailable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_available");

                entity.Property(e => e.PilotLocalAssist)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_local_assist");

                entity.Property(e => e.PilotRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_required");

                entity.Property(e => e.PortLatitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_latitude");

                entity.Property(e => e.PortLongitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_longitude");

                entity.Property(e => e.PortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_name");

                entity.Property(e => e.PortOfEntry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_of_entry");

                entity.Property(e => e.Provisions)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provisions");

                entity.Property(e => e.PublicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("publication_number");

                entity.Property(e => e.QuarantineOther)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_other");

                entity.Property(e => e.QuarantineProceduresRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_procedures_required");

                entity.Property(e => e.QuarantineSsccCertRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_sscc_cert_required");

                entity.Property(e => e.RailwayTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("railway_types");

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region_number");

                entity.Property(e => e.RepairTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("repair_types");

                entity.Property(e => e.ServicesElectrical)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_electrical");

                entity.Property(e => e.ServicesElectricalRepair)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_electrical_repair");

                entity.Property(e => e.ServicesLongshore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_longshore");

                entity.Property(e => e.ServicesNavEquip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_nav_equip");

                entity.Property(e => e.ServicesSteam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_steam");

                entity.Property(e => e.ShelterAfforded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shelter_afforded");

                entity.Property(e => e.TideRange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tide_range");

                entity.Property(e => e.TugAssist)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tug_assist");

                entity.Property(e => e.TugSalvage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tug_salvage");

                entity.Property(e => e.TurningArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turning_area");

                entity.Property(e => e.UsRepresentative)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("us_representative");

                entity.Property(e => e.Water)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("water");
            });

            modelBuilder.Entity<ThePort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ThePorts");

                entity.Property(e => e.AnchorageDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anchorage_depth");

                entity.Property(e => e.CargoAnchor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_anchor");

                entity.Property(e => e.CargoBeachMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_beach_moor");

                entity.Property(e => e.CargoIceMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_ice_moor");

                entity.Property(e => e.CargoMedMoor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_med_moor");

                entity.Property(e => e.CargoOilDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_oil_depth");

                entity.Property(e => e.CargoPierDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_pier_depth");

                entity.Property(e => e.CargoWharf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_wharf");

                entity.Property(e => e.ChannelDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("channel_depth");

                entity.Property(e => e.ChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chart_number");

                entity.Property(e => e.CommsAir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_air");

                entity.Property(e => e.CommsFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_fax");

                entity.Property(e => e.CommsPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_phone");

                entity.Property(e => e.CommsRadio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_radio");

                entity.Property(e => e.CommsRail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_rail");

                entity.Property(e => e.CommsVhf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comms_vhf");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CraneFixed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_fixed");

                entity.Property(e => e.CraneFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_float");

                entity.Property(e => e.CraneMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crane_mobile");

                entity.Property(e => e.DeckSupplies)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deck_supplies");

                entity.Property(e => e.Degauss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("degauss");

                entity.Property(e => e.Diesel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("diesel");

                entity.Property(e => e.DirtyBallast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dirty_ballast");

                entity.Property(e => e.DryDockTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dry_dock_types");

                entity.Property(e => e.EngSupplies)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eng_supplies");

                entity.Property(e => e.EntryIce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_ice");

                entity.Property(e => e.EntryOther)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_other");

                entity.Property(e => e.EntrySwell)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_swell");

                entity.Property(e => e.EntryTide)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry_tide");

                entity.Property(e => e.EtaMessageRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eta_message_required");

                entity.Property(e => e.FuelOil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fuel_oil");

                entity.Property(e => e.GarbageDispose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("garbage_dispose");

                entity.Property(e => e.GoodHoldingGround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("good_holding_ground");

                entity.Property(e => e.HarborSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("harbor_size");

                entity.Property(e => e.HarborType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("harbor_type");

                entity.Property(e => e.IndexNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("index_number");

                entity.Property(e => e.Lift024Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_0_24_tons");

                entity.Property(e => e.Lift100Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_100_tons");

                entity.Property(e => e.Lift2549Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_25_49_tons");

                entity.Property(e => e.Lift50100Tons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lift_50_100_tons");

                entity.Property(e => e.MaxVesselSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("max_vessel_size");

                entity.Property(e => e.MedFacility)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("med_facility");

                entity.Property(e => e.OverheadLimit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("overhead_limit");

                entity.Property(e => e.PilotAdvised)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_advised");

                entity.Property(e => e.PilotAvailable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_available");

                entity.Property(e => e.PilotLocalAssist)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_local_assist");

                entity.Property(e => e.PilotRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pilot_required");

                entity.Property(e => e.PortLatitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_latitude");

                entity.Property(e => e.PortLongitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_longitude");

                entity.Property(e => e.PortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_name");

                entity.Property(e => e.PortOfEntry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port_of_entry");

                entity.Property(e => e.Provisions)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provisions");

                entity.Property(e => e.PublicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("publication_number");

                entity.Property(e => e.QuarantineOther)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_other");

                entity.Property(e => e.QuarantineProceduresRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_procedures_required");

                entity.Property(e => e.QuarantineSsccCertRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quarantine_sscc_cert_required");

                entity.Property(e => e.RailwayTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("railway_types");

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region_number");

                entity.Property(e => e.RepairTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("repair_types");

                entity.Property(e => e.ServicesElectrical)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_electrical");

                entity.Property(e => e.ServicesElectricalRepair)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_electrical_repair");

                entity.Property(e => e.ServicesLongshore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_longshore");

                entity.Property(e => e.ServicesNavEquip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_nav_equip");

                entity.Property(e => e.ServicesSteam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("services_steam");

                entity.Property(e => e.ShelterAfforded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shelter_afforded");

                entity.Property(e => e.TideRange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tide_range");

                entity.Property(e => e.TugAssist)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tug_assist");

                entity.Property(e => e.TugSalvage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tug_salvage");

                entity.Property(e => e.TurningArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turning_area");

                entity.Property(e => e.UsRepresentative)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("us_representative");

                entity.Property(e => e.Water)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("water");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
