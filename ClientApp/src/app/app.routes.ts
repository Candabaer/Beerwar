import { Routes } from '@angular/router';
import {Weather} from '@pages/weather/weather';
import {ItemBattle} from './item-battle/item-battle';

export const routes: Routes = [
  { path: 'weather', component: Weather },
  { path: 'battle', component: ItemBattle },
];
