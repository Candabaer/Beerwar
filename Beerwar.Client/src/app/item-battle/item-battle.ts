import {Component} from '@angular/core';
import {ItemModel, ItemService} from '@services/item.service';

@Component({
  selector: 'app-item-battle',
  imports: [],
  templateUrl: './item-battle.html',
  styleUrl: './item-battle.scss'
})
export class ItemBattle {
  public items: ItemModel[] = [];
  constructor(private itemService: ItemService) {}
  ngOnInit() {
    this.getDuelantsForPage();
  }

  async getDuelantsForPage(): Promise<void> {
    await this.itemService.getDuelants();

  }
}
