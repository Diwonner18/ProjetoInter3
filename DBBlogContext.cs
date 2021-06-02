using System;
using Microsoft.EntityFrameworkCore;
using ProjetoInter03.Models;

namespace ProjetoInter03
{
    public class DBBlogContext : DbContext
    {
        public DBBlogContext(DbContextOptions<DBBlogContext> options)
            : base(options)
        {
            Database.EnsureCreated();

            SaveChanges();
        }

        public DBBlogContext()
        {
        }

        public DbSet<Consultorio> Consultorio { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialista> Especialista { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultorio>(entity => {
                entity.ToTable("consultorio");
                entity.HasKey(e => e.ConsultorioId);
                entity.Property(e => e.ConsultorioId).HasColumnName("id_consultorio").ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.NomeConsultorio).HasColumnName("nome_consultorio").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Rua).HasColumnName("rua_consultorio").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Numero).HasColumnName("numero_consultorio").HasColumnType("INT").IsRequired();
                entity.Property(e => e.Complemento).HasColumnName("complemento_consultorio").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Cep).HasColumnName("cep_consultorio").HasColumnType("INT").IsRequired();
            });

            modelBuilder.Entity<Especialista>(entity => {
                entity.ToTable("especialista");
                entity.HasKey(e => e.EspecialistaId);
                entity.Property(e => e.EspecialistaId).HasColumnName("id_especialista").ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.Especialidade).HasColumnName("especialidade").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Registro).HasColumnName("registro").HasColumnType("BIGINT").IsRequired();
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario").HasColumnType("INT").IsRequired();
                entity.HasOne(a => a.Usuario).WithOne(b => b.Especialista).HasForeignKey<Especialista>(b => b.UsuarioId);
            });

            modelBuilder.Entity<Paciente>(entity => {
                entity.ToTable("paciente");
                entity.HasKey(e => e.PacienteId);
                entity.Property(e => e.PacienteId).HasColumnName("id_paciente").ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.numeroCartao).HasColumnName("numeroCartao").HasColumnType("BIGINT").IsRequired();
                entity.Property(e => e.validade).HasColumnName("validade").HasColumnType("DATE").IsRequired();
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario").HasColumnType("INT").IsRequired();
                entity.HasOne(a => a.Usuario).WithOne(b => b.Paciente).HasForeignKey<Paciente>(b => b.UsuarioId);
            });

            modelBuilder.Entity<Consulta>(entity => {
                entity.ToTable("consulta");
                entity.HasKey(e => e.ConsultaId);
                entity.Property(e => e.ConsultaId).HasColumnName("id_consulta").ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.Data).HasColumnName("data_consulta").HasColumnType("DATE").IsRequired();
                entity.Property(e => e.EspecialistaId).HasColumnName("id_especialista").HasColumnType("INT").IsRequired();
                entity.Property(e => e.PacienteId).HasColumnName("id_paciente").HasColumnType("INT");
                entity.HasOne(a => a.Especialista).WithMany(b => b.Consulta).HasForeignKey(at => at.EspecialistaId);
                entity.HasOne(a => a.Paciente).WithMany(b => b.Consulta).HasForeignKey(at => at.PacienteId);
            });

            modelBuilder.Entity<Usuario>(entity => {
                entity.ToTable("usuario");
                entity.HasKey(e => e.UsuarioId);
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario").ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.Nome).HasColumnName("nome").HasColumnType("VARCHAR(50)").IsRequired();
                entity.Property(e => e.Sobrenome).HasColumnName("sobrenome").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Email).HasColumnName("email").HasColumnType("VARCHAR(100)").IsRequired();
                entity.Property(e => e.Senha).HasColumnName("senha").HasColumnType("VARCHAR(20)").IsRequired();
                entity.Property(e => e.Sexo).HasColumnName("sexo").HasColumnType("VARCHAR(15)").IsRequired();
                entity.Property(e => e.DataNascimento).HasColumnName("dataNascimento").HasColumnType("DATE").IsRequired();
                entity.Property(e => e.Token).HasColumnName("token").HasColumnType("VARCHAR(40)");
            });

        }
        
    }
}