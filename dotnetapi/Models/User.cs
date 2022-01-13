namespace dotnetapi.Models
{
    public class User : BaseModel
    {
        IList<User> Users = new List<User>();

        public string? Name { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }
    }

}


