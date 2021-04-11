import { Component, OnInit } from '@angular/core';
import { BasketService } from '../basket/basket.service';
import { IBasket } from '../shared/models/basket';
import { IOrder } from '../shared/models/order';
import { CheckoutService } from './checkout.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss'],
})
export class CheckoutComponent implements OnInit {
  constructor(
    private basketService: BasketService,
    private checkoutService: CheckoutService,
    
  ) {}

  public directAccessToOrdersUrl = '';
  
  ngOnInit(): void {}

  submitOrder() {
    const basket = this.basketService.getCurrentBasketValue();
    const orderToCreate = this.getOrderToCreate(basket);
    this.checkoutService.createOrder(orderToCreate).subscribe(
      (order: IOrder) => {
        this.basketService.deleteLocalBasket(basket.id);
        console.log(order);
        this.directAccessToOrdersUrl = order.directAccessToOrdersUrl;
      },
      (error) => {
        console.log(error);
      }
    );
  }

  private getOrderToCreate(basket: IBasket) {
    return {
      basketId: basket.id,
    };
  }
}
