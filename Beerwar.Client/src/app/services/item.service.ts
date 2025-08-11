import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environment';
import { Observable } from 'rxjs';
import { Client } from '@api/match';

export interface ItemModel {
  Name: string;
  ShortName: string;
  Description?: string;
  Rating: number;
  ImageSource?: string;
}
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

  async getDuelants(): Promise<ItemModel[]> {

    const response = await this.client.create();
    if (!response.ok) {
      throw new Error(`HTTP error, getting Duelants failed! status: ${response.status}`);
    }
    return response.json();
  }


}
