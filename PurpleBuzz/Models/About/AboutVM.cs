using System;

namespace PurpleBuzz.Models.About;

public class AboutVM
{
    public List<PrioritesVM> Priorites { get; set; }
    public List<TeamMemberVM> TeamMembers { get; set; }
}
