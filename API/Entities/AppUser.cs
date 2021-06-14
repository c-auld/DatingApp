namespace API.Entities
{
    public class AppUser
    {
        //Primary key and int for auto increment
        //Must be public so Entity Framework can access
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}