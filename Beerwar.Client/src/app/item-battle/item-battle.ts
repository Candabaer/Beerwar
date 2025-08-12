import { Component, OnInit } from '@angular/core';
import { ItemService } from '@services/item.service';
import { environment } from '@environment';

@Component({
  selector: 'app-item-battle',
  imports: [],
  templateUrl: './item-battle.html',
  styleUrl: './item-battle.scss'
})
export class ItemBattle implements OnInit {

  constructor(private itemService: ItemService) {
  }
  ngOnInit() {
    this.getDuelantsForPage();
  }

  async getDuelantsForPage(): Promise<void> {
    await this.itemService.getDuelants();
  }
}
