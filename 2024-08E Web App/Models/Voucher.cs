namespace _2024_08E_Web_App.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public string ReceiptNo { get; set; }
        public string Date { get; set; }
        public string EnrollmentNo { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentRefrence { get; set; }
        public string CashAmount { get; set; }
        public string OnlineAmount { get; set; }
        public string Status { get; set; }
    }
}
