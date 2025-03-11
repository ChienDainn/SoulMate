namespace API.Entities

{
    public class UserLike
    {
        public int SourceUserId { get; set; } // Người thực hiện like
        public AppUser? SourceUser { get; set; }

        public int LikedUserId { get; set; } // Người được like
        public AppUser? LikedUser { get; set; }
    }

}