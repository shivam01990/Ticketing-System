using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
namespace ModelEntity
{
    [Table("Users")]
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public int DistrictId { get; set; }
        public int StateId { get; set; }
        public virtual StateModel State { get; set; }
        public virtual DistrictModel District { get; set; }
        
    }
}
