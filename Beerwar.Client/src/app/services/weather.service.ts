import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment  } from '@environment';
import { Observable } from 'rxjs';

export interface WeatherForecastModel {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  private endpoint = '/weatherforecast';

  constructor(private http: HttpClient) {}

  async getForecast(): Promise<WeatherForecastModel[]> {
    const response = await fetch(environment.apiBaseUrl + this.endpoint);
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }
    return response.json();
  }

}
