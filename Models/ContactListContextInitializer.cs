using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleContactList.Models
{
    public class ContactListContextInitializer : DropCreateDatabaseIfModelChanges<ContactListContext>
    {
        protected override void Seed(ContactListContext context)
        {
            base.Seed(context);
        }
    }
}