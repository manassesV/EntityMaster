
namespace EntityMaster
{
    public class Post
    {
        public int id { get; set; }
        public string name { get; set; }

        public int id_blog {  get; set; }
        public Blog blog { get; set; }

        public virtual ICollection<Tags>  Tags{ get; set; } = new List<Tags>();
    }
}
