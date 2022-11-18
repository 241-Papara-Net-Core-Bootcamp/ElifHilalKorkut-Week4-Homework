using Dapper.Contrib.Extensions;
using System;
namespace Dapper.Domain.Entities
{
    [Table("Customer")]
    public class Customer:BaseEntity
    {

        [Key]
        // public int Customer_Code { get; set; }
        //public int Id { get; set; }
        public string Customer_Name { get; set; }
        public DateTime CreatedDate { get; set; }

        // public string Customer_City { get; set; }
        //public int Customer_AccountNumber { get; set; }
        // public string Customer_Email { get; set; }



    }
}
