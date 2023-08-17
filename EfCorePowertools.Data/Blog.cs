﻿namespace EfCorePowertools.Data;

internal sealed class Blog
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Url { get; set; } = default!;
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}