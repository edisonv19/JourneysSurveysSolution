namespace Infrastructure.DbContext.Utils
{
    public class Parameter
    {
        public string Name { get; set; }
        
        public object Value { get; set; }

        public DbTypes Type { get; set; }
    }
}
