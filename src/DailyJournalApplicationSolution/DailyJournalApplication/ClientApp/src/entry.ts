export class Entry {
  date?: string | null;
  mood?: string | null;
  affirmation?: string | null;
  achievement?: string | null;
  nonAchievement?: string | null;
  tomorrowsGoal?: string | null;
  rating?: number | null;
  constructor(date?: string | null, mood?: string | null, affirmation?: string | null, achievement?: string | null,
    nonAchievement?: string | null, tomorrowsGoal?: string | null, rating?: number | null) {
    this.date = date;
    this.mood = mood;
    this.affirmation = affirmation;
    this.achievement = achievement;
    this.nonAchievement = nonAchievement;
    this.tomorrowsGoal = tomorrowsGoal;
    this.rating = rating;
  }
}
