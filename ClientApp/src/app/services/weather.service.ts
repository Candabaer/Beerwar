import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
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
  private apiUrl = 'http://localhost:5000/weatherforecast';

  constructor(private http: HttpClient) {}

  getForecast(): Observable<WeatherForecastModel[]> {
    return this.http.get<WeatherForecastModel[]>(this.apiUrl);
  }

}
