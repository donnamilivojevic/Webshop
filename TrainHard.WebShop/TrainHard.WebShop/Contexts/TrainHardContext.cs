namespace TrainHard.WebShop.Contexts
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TrainHard : DbContext
    {
        // Your context has been configured to use a 'TrainHard' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TrainHard.WebShop.Contexts.TrainHard' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TrainHard' 
        // connection string in the application configuration file.
        public TrainHard()
            : base("name=TrainHard")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderRow> OrderRows { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}