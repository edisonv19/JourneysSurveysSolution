namespace Infrastructure.DbContext.Utils
{
    public class Parameter
    {
        public string Name { get; set; }
        
        public object Value { get; set; }

        public DbTypes Type { get; set; }

        public int Size { get; set; } = 0;

        public bool IsNullable { get; set; }
    }
}
