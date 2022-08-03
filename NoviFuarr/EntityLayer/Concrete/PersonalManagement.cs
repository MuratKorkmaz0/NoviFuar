using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class PersonalManagement
    {
        //System user parametres Model
        [Key]
        [Column("PersonalID")]
        public int PersonalID { get; set; }


        [Column("PersonalName")]
        public string  PersonalName { get; set; }


        [Column("PersonalSurname")]
        public string PersonalSurname { get; set; }


        [Column("PersonalUserName")]
        public string PersonalUserName { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal PersonalPassword { get; set; }

        
        [Column("PersonalRoles")]
        public string PersonalRoles { get; set; }
        

        [Column("PersonalDateTime")]
        public DateTime PersonalDateTime { get; set; }

        


    }
}
