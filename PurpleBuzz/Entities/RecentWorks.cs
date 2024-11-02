using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Entities;

[Table("recent_works")]
public class RecentWorks : BaseEntity
{
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("image_url")]
    public string ImageUrl { get; set; }
}
