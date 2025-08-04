import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment  } from '@environment';
import { Observable } from 'rxjs';

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

  constructor(private http: HttpClient) {}

  async getDuelants(): Promise<ItemModel[]> {
    const response = await fetch(environment.apiBaseUrl + this.getMatchURL);
    if (!response.ok) {
      throw new Error(`HTTP error, getting Duelants failed! status: ${response.status}`);
    }
    return response.json();
  }


}
