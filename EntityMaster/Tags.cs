namespace EntityMaster
{
    public class Tags
    {
        public int id {  get; set; }
        public string name { get; set; }

        public virtual ICollection<Post> posts { get; set; }= new List<Post>();
    }
}
