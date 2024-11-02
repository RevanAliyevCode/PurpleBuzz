using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Entities;

[Table("contacts")]
public class Contact : BaseEntity
{
    [Column("title")]
    public string Title { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("phone")]
    public string Phone { get; set; }
    [Column("icon_tag")]
    public string IconTag { get; set; }
}
