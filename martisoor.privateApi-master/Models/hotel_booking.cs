namespace bknsystem.privateApi.Models
{
    public class hotel_booking
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string special_requirements { get; set; }
        public string hotel_id { get; set; }
        public string room_id { get; set; }

        public string booking_status { get; set; }

        public booking_payment booking_payment { get; set; }
    }
}