using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Entities;

[Table("team_members")]
public class TeamMember : BaseEntity
{
    [Column("name")]
    public string Name { get; set; }
    [Column("surname")]
    public string? Surname { get; set; }
    [Column("position")]
    public string Position { get; set; }
    [Column("image_url")]
    public string ImageUrl { get; set; }
}
