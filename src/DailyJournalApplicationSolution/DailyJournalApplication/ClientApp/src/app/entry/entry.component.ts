import { Component } from '@angular/core';
import { EntryService } from '../../entryservice.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Entry } from '../../entry';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-entry-component',
  templateUrl: './entry.component.html'
})
export class EntryComponent {
  constructor(private entryService: EntryService, private formBuilder: FormBuilder) { }

  newEntry: Observable<Entry> | undefined;
    newEntryForm: FormGroup = this.formBuilder.group({
      date: '',
      mood: '',
      affirmation: '',
      achievement: '',
      nonAchievement: '',
      tomorrowsGoal: '',
      rating: 0,
    });

  onSubmit(): void {
    const entry: Entry = this.newEntryForm.value;
    console.log(entry.date);
    this.newEntry = this.entryService.createEntry(entry);

    this.newEntry.subscribe(() => {
      window.alert(`Your Entry for this date ${entry.date} has been inputted into your journal.`);
    });
  }
}
