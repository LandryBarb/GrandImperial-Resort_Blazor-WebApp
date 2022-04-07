namespace GrandImperial.Client.Features.Home
{
    public class HotelRoom 
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string RoomName { get; set; }
        public int Occupancy { get; set; }
        public double RoomRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }
        public double TotalDays { get; set; }
        public double TotalAmount { get; set; }
        public IEnumerable<HotelRoomImage>? HotelRoomImages { get; set; } = Array.Empty<HotelRoomImage>();
    
        public List<string> ImageUrls { get; set; }
        public bool IsBooked { get; set; }
    } 

    public class HotelRoomImage 
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public string? RoomImageUrl { get; set; }
    }
}