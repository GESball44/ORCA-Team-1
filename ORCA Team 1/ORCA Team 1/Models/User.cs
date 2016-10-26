using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ORCA_Team_1.Models
{
    public class User
    {

        [Key]
        public string userId { get; set; }

        [Required]
        public string Email { get; set; }

        //This is where I'm going to attempt to add my own code to the table

        //these are user entered fields
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        //where the user is from
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        //what organizate user is with
        [Required]
        public string Organization { get; set; }

        //these are preset field that the user doesnt enter

        //tells whether they are regular user or expert
        //should default to regular
        public string UserType { get; set; }
        //isAdmin should default to false
        public bool IsAdmin { get; set; }
        //get this from local machine for now
        public string CreateDate { get; set; }

    }

    //public class DefaultConnection : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public DbSet<Expert> Experts { get; set; }
    //}
}