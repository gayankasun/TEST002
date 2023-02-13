namespace TEST002.TEST002.Domain
{
    public class InvoiceHeader : BaseEntity
    {
        public int DocumentId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal InvoiceSubTotal { get; set; }
        public decimal GstTotal { get; set; }
        public decimal InvoiceTotal { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
    }
}
