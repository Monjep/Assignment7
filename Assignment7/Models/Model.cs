using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment7.Models
{
    public class ModelContext: DbContext

    { 
        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {}
        public DbSet<User> Users { get; set; }
        public DbSet<Notes> notes { get; set; }
        public DbSet<Category> Categorys { get; set; }

        public class User

        {
            public int userId { get; set; }
            public string Email { get; set; }
            public string Name{ get; set; }
            public string CreatedOn { get; set; }

        }


        public class Notes
        {
            public int id { get; set; }
            public string Title { get; set; }
            public string note { get; set; }
            public string CreatedOn { get; set; }
            public int categoryId { get; set; }
            public string Isdeleted { get; set; }
            public int userId { get; set; }
            

        }

        public class Category
        {

            public int id { get; set; }
            public string Name { get; set; }


        }



    }
        }
    

  

