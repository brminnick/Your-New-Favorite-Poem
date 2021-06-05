using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Your_New_Favorite_Poem.Models
{
    [Table("poems")]
    public class Poem : IDatabaseModel
    {
        public Poem()
        {

        }
        
        [Key, DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public int Id { get; init; }

        public Author Author { get; init; } = new Author();

        public string Title { get; init; } = string.Empty;

        public Uri? URL { get; init; }

        public bool IsDeleted { get; init; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public DateTimeOffset CreatedAt { get; init; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Computed)]
        public DateTimeOffset UpdatedAt { get; init; }

        public bool IsVerified { get; init; } = false;

    }


}
