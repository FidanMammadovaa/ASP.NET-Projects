namespace Checkout.Models
{
    public class Result
    {
        public string Id { get; set; }
        public ImageInfo Image { get; set; }
        public int RunningTimeInMinutes { get; set; }
        public string Title { get; set; }
        public string TitleType { get; set; }
        public int Year { get; set; }
        public List<Principal> Principals { get; set; }
    }

    public class ImageInfo
    {
        public int Height { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }

    public class Principal
    {
        public string Id { get; set; }
        public string LegacyNameText { get; set; }
        public string Name { get; set; }
        public int Billing { get; set; }
        public string Category { get; set; }
        public List<string> Characters { get; set; }
        public List<Role> Roles { get; set; }
    }

    public class Role
    {
        public string Character { get; set; }
        public string CharacterId { get; set; }
    }


    public class IMDb
    {
        public List<Result> Results { get; set; }
    }
    
}
