using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Forum.Data;

// Add profile data for application users by adding properties to the ForumUser class
public class ForumUser : IdentityUser
{
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Post> Posts { get; set; }
}

