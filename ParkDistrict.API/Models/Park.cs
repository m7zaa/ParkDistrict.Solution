namespace ParkDistrict.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Playground { get; set; }
        public bool PicnicArea { get; set; }
        public bool Bathroom { get; set; }
    }
}