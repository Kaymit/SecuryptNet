using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SecuryptNet.Models;

namespace SecuryptNet.DAL
{
    public class FileContext : DbContext
    {
        public FileContext() : base("FileContext")
        {

        }

        public DbSet<EncryptedItem> EncryptedItems { get; set; }
    }
}