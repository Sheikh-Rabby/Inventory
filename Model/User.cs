namespace Inventory.Model
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string? isActive { get; set; }
        public string phone { get; set; } = "01965236885";
    }
}
