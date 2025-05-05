namespace EntityMaster
{
    public class Blog
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
