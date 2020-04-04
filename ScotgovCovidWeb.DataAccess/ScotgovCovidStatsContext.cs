using Microsoft.EntityFrameworkCore;

namespace ScotgovCovidWeb.DataAccess
{
    public partial class ScotgovCovidStatsContext : DbContext
    {
        public ScotgovCovidStatsContext()
        {
        }

        public ScotgovCovidStatsContext(DbContextOptions<ScotgovCovidStatsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Datasets> Datasets { get; set; }
        public virtual DbSet<PgStatStatements> PgStatStatements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("plv8")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2");

            modelBuilder.Entity<Datasets>(entity =>
            {
                entity.ToTable("datasets");

                entity.HasIndex(e => e.Date)
                    .HasName("datasets_date_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AyrshireandarranCases).HasColumnName("ayrshireandarran_cases");

                entity.Property(e => e.BordersCases).HasColumnName("borders_cases");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DumfriesandgallowayCases).HasColumnName("dumfriesandgalloway_cases");

                entity.Property(e => e.FifeCases).HasColumnName("fife_cases");

                entity.Property(e => e.ForthvalleyCases).HasColumnName("forthvalley_cases");

                entity.Property(e => e.GrampianCases).HasColumnName("grampian_cases");

                entity.Property(e => e.GreaterglasgowandclydeCases).HasColumnName("greaterglasgowandclyde_cases");

                entity.Property(e => e.HighlandCases).HasColumnName("highland_cases");

                entity.Property(e => e.LanarkshireCases).HasColumnName("lanarkshire_cases");

                entity.Property(e => e.LothianCases).HasColumnName("lothian_cases");

                entity.Property(e => e.NegativeTests).HasColumnName("negative_tests");

                entity.Property(e => e.OrkneyCases).HasColumnName("orkney_cases");

                entity.Property(e => e.PositiveTests).HasColumnName("positive_tests");

                entity.Property(e => e.ShetlandCases).HasColumnName("shetland_cases");

                entity.Property(e => e.TaysideCases).HasColumnName("tayside_cases");

                entity.Property(e => e.TotalDeaths).HasColumnName("total_deaths");

                entity.Property(e => e.TotalTests).HasColumnName("total_tests");
            });

            modelBuilder.Entity<PgStatStatements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnName("dbid")
                    .HasColumnType("oid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("oid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
