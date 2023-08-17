namespace EfCorePowertools.Data;

internal sealed class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public int BlogId { get; set; }
    public Blog Blog { get; set; } = default!;
}