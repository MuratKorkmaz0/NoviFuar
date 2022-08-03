using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{


    public class Visitors
    {
        [Key]
        [Column("VisitorID")]
        public int VisitorID { get; set; }

        [Column("Number1")]
        public string Number1 { get; set; }

        [Column("Number2")]
        public string Number2 { get; set; }

        [Column("BarCode")]
        public string BarCode { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }
        
        [Column("CompanyName")]
        public string CompanyName { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("WebAddress")]
        public string WebAddress { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Contry")]
        public string Contry { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("PriceTyp")]
        public string PriceTyp { get; set; }
       
        
        /*[DataType(DataType.Date)]
            [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
            public DateTime DateTime { get; set; }
            */

    }
}
