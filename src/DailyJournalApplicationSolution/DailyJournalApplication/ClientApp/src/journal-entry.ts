export class JournalEntry {
    constructor(
        public date: string,
        public mood: string,
        public affirmation: string,
        public achievement: string,
        public nonAchievement: string,
        public tomorrowsGoal: string,
        public rating: number
    ) {
        this.date = date;
        this.mood = mood;
        this.affirmation = affirmation;
        this.achievement = achievement;
        this.nonAchievement = nonAchievement;
        this.tomorrowsGoal = tomorrowsGoal;
        this.rating = rating;
    }
}
