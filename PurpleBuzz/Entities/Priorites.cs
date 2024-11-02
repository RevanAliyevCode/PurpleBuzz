using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Entities;

[Table("priorites")]
public class Priorites : BaseEntity
{
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("icon_tag")]
    public string IconTag { get; set; }
}
