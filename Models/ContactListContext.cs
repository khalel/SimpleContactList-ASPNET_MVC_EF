using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SimpleContactList.Models
{
    public class ContactListContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactListContext() : base("ContactListContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<IncludeMetadataConvention>(); // Need this for godaddy hosting for my demo

            Database.SetInitializer<ContactListContext>(null);  // Need this for godaddy hosting for my demo
        }
    }
}