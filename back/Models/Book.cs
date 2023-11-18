using System;
using System.Collections.Generic;

namespace back.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int? NbPages { get; set; }

    public DateOnly? PublisheDat { get; set; }
}
