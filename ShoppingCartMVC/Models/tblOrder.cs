﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{
    public partial class tblOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public int? ProID { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public string Method { get; set; }

        public int? Unit { get; set; }

        public int? Qty { get; set; }

        public string Extras { get; set; } = "None";

        public int ExtrasCost { get; set; }

        public int? Total { get; set; }

        [DisplayName("Order Date")]
        public DateTime? OrderDate { get; set; }
        public string RefundStatus { get; set; }

        public string OrderReady { get; set; }

        public int? InvoiceId { get; set; }

        public bool Rated { get; set; } = false;

        public virtual tblProduct TblProduct { get; set; }

        public virtual tblInvoice TblInvoice { get; set; }
    }
}