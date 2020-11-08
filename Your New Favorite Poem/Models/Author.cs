﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Your_New_Favorite_Poem.Constants;

namespace Your_New_Favorite_Poem.Models
{
    [Table("authors")]
    public class Author : IDatabaseModel
    {
        [Key, DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public List<Poem> Poems { get; set; } = new List<Poem>();
        public Uri? PictureURL { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public DateTimeOffset UpdatedAt { get; set; }
        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Computed)]
        public bool IsVerified { get; set; }
    }
}
