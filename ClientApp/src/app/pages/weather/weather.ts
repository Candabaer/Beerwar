import { Component, OnInit } from '@angular/core';
import { WeatherService, WeatherForecastModel } from '@services/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.scss']
})
export class WeatherComponent implements OnInit {
  forecasts: WeatherForecastModel[] = [];

  constructor(private weatherService: WeatherService) {}

  ngOnInit(): void {
    this.weatherService.getForecast().subscribe(data => {
      this.forecasts = data;
    });
  }
}
