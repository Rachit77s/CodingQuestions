
public class Main {
    public static void main(String[] args) {

        ShoppingCart cart = new ShoppingCart();
        CartItem product1 = new Product("Product1", 10.0, "Type1");
        CartItem coupon1 = new Coupon(CouponType.PERCENT_OFF, 10);
        // CartItem coupon2 = new Coupon(CouponType.NEXT_ITEM_PERCENT_OFF, 5);
        // CartItem coupon3 = new Coupon(CouponType.NTH_ITEM_TYPE_T_PERCENT_OFF, 15, 2, "Type2");
        CartItem product2 = new Product("Product2", 20.0, "Type2");

        /*
            1. Coupon: Take 10% off the next product in the cart
            2. $10 postcard sorter
            3. $20 stationery organizer
         */
//        cart.addItem(coupon1);
//        cart.addItem(product1);
//        cart.addItem(product2);

        /*
            1. $10 postcard sorter
            2. Coupon: Take 10% off the next product in the cart
            3. $20 stationery organizer
            The cart total here is $28.
         */
        cart.addItem(product1);
        cart.addItem(coupon1);
        cart.addItem(product2);

        double netPrice = cart.getTotalPrice();
        System.out.println("Net Price after applying coupons: $" + netPrice);
    }
}