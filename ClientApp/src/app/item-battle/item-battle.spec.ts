import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemBattle } from './item-battle';

describe('ItemBattle', () => {
  let component: ItemBattle;
  let fixture: ComponentFixture<ItemBattle>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItemBattle]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItemBattle);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
