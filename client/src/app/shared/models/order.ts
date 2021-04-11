export interface IOrderToCreate {
  basketId: string;
}

export interface IOrder {
  id: number;
  buyerEmail: string;
  orderDate: string;
  orderItems: IOrderItem[];
  total: number;
  directAccessToOrdersUrl: string;
}

export interface IOrderItem {
  productId: number;
  productName: string;
  pictureUrl: string;
  price: number;
  quantity: number;
}
