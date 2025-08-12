import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environment';
import { Observable } from 'rxjs';
import { Client, MatchData } from '@api/matchclient';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  private getMatchURL = '/api/Match/create';
  private setWinnerURL = '/api/Match/finalize';
  public client: Client;

  constructor(private http: HttpClient) {
    this.client = new Client(environment.apiBaseUrl);
  }

  async getDuelants(): Promise<MatchData> {
    return this.client.create();
  }
}
