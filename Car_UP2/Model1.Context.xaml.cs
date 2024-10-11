using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Car_UP2
{
    /// <summary>
    /// Логика взаимодействия для Model1.xaml
    /// </summary>
    
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class CarDealershipEntities : DbContext
    {
        public CarDealershipEntities()
            : base("name=DealershipEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
    }
}