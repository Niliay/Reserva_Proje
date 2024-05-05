using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        //metot:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-182DPJM\\SQLEXPRESS; database=ReservaDB; integrated security=true; ");
        }

        public DbSet<AltHakkimizda> AltHakkimizdas { get; set; }
        public DbSet<Bulten> Bultens { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas  { get; set; }
        public DbSet<Hakkimizda2>  Hakkimizda2s { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<OneCikanlar> OneCikanlars { get; set; }
        public DbSet<OneCikanlar2> OneCikanlar2s { get; set; }
        public DbSet<TatilYerleri> TatilYerleris { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Yorumlar2> Yorumlar2s { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }



    }
}
