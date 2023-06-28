import { Component } from '@angular/core';
import { Entry } from '../../entry';
import { Observable } from 'rxjs';
import { EntryService } from '../../entryservice.service';

@Component({
  selector: 'app-entries-list',
  templateUrl: './entries-list.component.html',
  styleUrls: ['./entries-list.component.css']
})
export class EntriesListComponent {
  constructor(private entryService: EntryService) { }

  entries: Entry[] | undefined;

  ngOnInit() {
    this.entries = this.entryService.getAllEntries();
  }
}
