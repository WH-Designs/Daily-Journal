import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Entry } from './entry';

@Injectable({
  providedIn: 'root'
})
export class EntryService { 
  public entries!: Entry[];
  private baseUrl!: string;

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  createEntry(entry: Entry): Observable<Entry> {
    return this.httpClient.post<Entry>(this.baseUrl + 'entry', entry);
  }

  getAllEntries(): Entry[] {
    this.httpClient.get<Entry[]>(this.baseUrl + 'entry').subscribe(result => {
      this.entries = result;
    }, error => console.error(error));

    return this.entries;
  }
}
