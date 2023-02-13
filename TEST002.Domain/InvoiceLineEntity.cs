namespace TEST002.TEST002.Domain
{
    public class InvoiceLineEntity
    {
        public short LineNo { get; set; }
        public int DocumentId { get; set; }
        public string UOM { get; set; }
        public decimal? InvoiceQuantity { get; set; }
        public decimal LineAmount { get; set; }
    }
}
