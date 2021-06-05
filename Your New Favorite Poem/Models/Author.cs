using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Your_New_Favorite_Poem.Models
{
    [Table("authors")]
    public class Author : IDatabaseModel
    {
        [Key, DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public int Id { get; init; }

        public string Name { get; init; } = string.Empty;

        public string Bio { get; init; } = string.Empty;

        public List<Poem> Poems { get; init; } = Enumerable.Empty<Poem>().ToList();

        public Uri? PictureURL { get; init; }

        public string PictureAltText { get; init; } = string.Empty;

        public bool IsDeleted { get; init; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public DateTimeOffset CreatedAt { get; init; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Computed)]
        public DateTimeOffset UpdatedAt { get; init; }

        public bool IsVerified { get; init; }
    }
}
