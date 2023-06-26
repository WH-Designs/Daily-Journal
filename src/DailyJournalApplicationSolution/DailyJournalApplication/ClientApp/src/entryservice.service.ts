import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Entry } from './entry';

@Injectable({
  providedIn: 'root'
})
export class EntryService {
  private apiUrl = 'api/Entry';

  constructor(private httpClient: HttpClient) { }

  createEntry(entry: Entry): Observable<Entry> {
    return this.httpClient.post<Entry>(this.apiUrl, entry);
  }

  getAllEntries(): Observable<Entry[]> {
    return this.httpClient.get<Entry[]>(this.apiUrl);
  }
}
