using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SENAI.SPMedicalGroup.WebApi.Domains;

#nullable disable

namespace SENAI.SPMedicalGroup.WebApi.Contexts
{
    public partial class SPMedicalGroupContext : DbContext
    {
        public SPMedicalGroupContext()
        {
        }

        public SPMedicalGroupContext(DbContextOptions<SPMedicalGroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinicas> Clinicas { get; set; }
        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Situacoes> Situacoes { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-IUR0PGGG; initial catalog = SPMedicalGroup; user Id = sa; pwd = Fiona1997*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Clinicas>(entity =>
            {
                entity.HasKey(e => e.idClinica)
                    .HasName("PK__Clinicas__C73A6055A50AEC45");

                entity.HasIndex(e => e.CNPJ, "UQ__Clinicas__AA57D6B4777A314E")
                    .IsUnique();

                entity.Property(e => e.CNPJ)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Razão_social)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Razão social");

                entity.Property(e => e.UF)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Consultas>(entity =>
            {
                entity.HasKey(e => e.idConsulta)
                    .HasName("PK__Consulta__CA9C61F5E2C5D6A0");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.idSituacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.idMedicoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.idMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__idMed__4E88ABD4");

                entity.HasOne(d => d.idPacienteNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.idPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__idPac__4D94879B");

                entity.HasOne(d => d.idSituacaoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.idSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__idSit__4F7CD00D");
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => e.idEspecialidade)
                    .HasName("PK__Especial__40969805ED51803F");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.idMedico)
                    .HasName("PK__Medicos__4E03DEBA115ADA37");

                entity.HasIndex(e => e.CRM, "UQ__Medicos__C1F887FFA43A028E")
                    .IsUnique();

                entity.Property(e => e.CRM)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.idClinicaNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.idClinica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicos__idClini__44FF419A");

                entity.HasOne(d => d.idEspecialidadeNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.idEspecialidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicos__idEspec__440B1D61");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.idUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicos__idUsuar__45F365D3");
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.HasKey(e => e.idPaciente)
                    .HasName("PK__Paciente__F48A08F2A3B62546");

                entity.HasIndex(e => e.RG, "UQ__Paciente__321537C88B257C98")
                    .IsUnique();

                entity.HasIndex(e => e.CPF, "UQ__Paciente__C1F89731822BB615")
                    .IsUnique();

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CEP)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CPF)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Data_de_nascimento)
                    .HasColumnType("date")
                    .HasColumnName("Data de nascimento");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RG)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UF)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.idUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pacientes__idUsu__4AB81AF0");
            });

            modelBuilder.Entity<Situacoes>(entity =>
            {
                entity.HasKey(e => e.idSituacao)
                    .HasName("PK__Situacoe__12AFD197CD53B514");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuarios>(entity =>
            {
                entity.HasKey(e => e.idTipo)
                    .HasName("PK__TipoUsua__BDD0DFE18FCE869E");

                entity.Property(e => e.Identificação)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.idUsuario)
                    .HasName("PK__Usuarios__645723A682977315");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D10534E6A9BE93")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.idTipoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.idTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__idTipo__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
