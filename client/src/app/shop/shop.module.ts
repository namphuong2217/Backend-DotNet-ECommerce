import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShopComponent } from './shop.component';
import { ProductItemComponent } from './product-item/product-item.component';
import { SharedModule } from '../shared/shared.module';
import { ProductDetailsComponent } from './product-details/product-details.component';
// import { RouterModule } from '@angular/router';
import { ShopRoutingModule } from './shop-routing.module';
import { BasketComponent } from '../basket/basket.component';
import { BasketModule } from '../basket/basket.module';



@NgModule({
  declarations: [ShopComponent, ProductItemComponent, ProductDetailsComponent],
  imports: [
    CommonModule,
    SharedModule,
    ShopRoutingModule,
    BasketModule
    // RouterModule
  ],
  exports: [BasketComponent]
})
export class ShopModule { }
