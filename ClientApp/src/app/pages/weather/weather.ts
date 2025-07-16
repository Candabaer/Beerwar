import {Component, OnInit} from '@angular/core';
import {WeatherService, WeatherForecastModel} from '@services/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.html',
  styleUrls: ['./weather.scss']
})
export class Weather implements OnInit {
  public forecasts: WeatherForecastModel[] = [];

  constructor(private weatherService: WeatherService) {
  }

  ngOnInit() {
    this.loadForecasts();
  }

  private async loadForecasts(): Promise<void> {
    try {
      this.forecasts = await this.weatherService.getForecast();
    } catch (error) {
      console.error('Fehler beim Laden:', error);
    }
  }
}
