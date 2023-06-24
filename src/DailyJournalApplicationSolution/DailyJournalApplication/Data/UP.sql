CREATE TABLE [Entry] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Date] nvarchar(64),
  [Mood] nvarchar(8),
  [Affirmation] nvarchar(32),
  [Achievement] nvarchar(64),
  [NonAchievement] nvarchar(64),
  [TomorrowsGoal] nvarchar(64),
  [Rating] int
);
