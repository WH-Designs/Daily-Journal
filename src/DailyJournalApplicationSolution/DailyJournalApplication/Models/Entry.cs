using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DailyJournalApplication.Models;

[Table("Entry")]
public partial class Entry
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(64)]
    public string Date { get; set; }

    [StringLength(8)]
    public string Mood { get; set; }

    [StringLength(32)]
    public string Affirmation { get; set; }

    [StringLength(64)]
    public string Achievement { get; set; }

    [StringLength(64)]
    public string NonAchievement { get; set; }

    [StringLength(64)]
    public string TomorrowsGoal { get; set; }

    public int? Rating { get; set; }
}
