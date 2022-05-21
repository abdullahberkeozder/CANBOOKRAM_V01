using System;
using System.Collections.Generic;

namespace CANBOOKRAM_V01.Models
{
    public partial class ProfileDetail
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}
