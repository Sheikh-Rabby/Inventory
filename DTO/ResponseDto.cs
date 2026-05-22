namespace Inventory.DTO
{
    public class ResponseDto
    {
       

        public string username { get; set; }
        public string message { get; set; }
    }

    public class LoginResponseDto
    {
        public string username { get; set; }
        public string message { get; set; }
        public string token { get; set; }
    }
}