using System;

namespace Your_New_Favorite_Poem.Models
{
    //Interface to force classes to include properties needed in database
    public interface IDatabaseModel
    {
        public int Id { get; init; }

        public bool IsDeleted { get; init; }

        public DateTimeOffset CreatedAt { get; init; }

        public DateTimeOffset UpdatedAt { get; init; }

        public bool IsVerified { get; init; }
    }
}
