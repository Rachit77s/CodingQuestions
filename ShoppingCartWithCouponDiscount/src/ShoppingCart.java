import java.util.*;

public class ShoppingCart {

    //    private List<Product> products;
    //    private List<Coupon> coupons;

    // Instead of above two, create a wrapper class CartItem
    private List<CartItem> cartItemList;

    public ShoppingCart() {
//        this.products = new ArrayList<>();
//        this.coupons = new ArrayList<>();
        this.cartItemList = new ArrayList<>();
    }

    public void addItem(CartItem cartItem) {
        cartItemList.add(cartItem);
    }

    public double getTotalPrice() {
        double totalPrice = 0;
        List<Coupon> coupons = new ArrayList<>();

        for(CartItem item : cartItemList)
        {
            if(item instanceof Product)
            {
                // Check coupon already present
                if (coupons.size() > 0) {
                    Coupon coupon = coupons.get(0);
                    coupons.remove(0);

                    if (coupon.getCouponType() == CouponType.PERCENT_OFF) {
                        totalPrice += ((Product) item).getPrice() - (((Product) item).getPrice() * coupon.getDiscountPercentage()) / 100;
                    } else if (coupon.getCouponType() == CouponType.NEXT_ITEM_PERCENT_OFF) {
                        totalPrice += ((Product) item).getPrice() - (((Product) item).getPrice() * coupon.getDiscountPercentage()) / 100;
                    } else if (coupon.getCouponType() == CouponType.NTH_ITEM_TYPE_T_PERCENT_OFF) {
                        totalPrice += ((Product) item).getPrice() - coupon.getDiscountPercentage();
                    }
                }
                else {
                    totalPrice += ((Product) item).getPrice();
                }
            }
            else if (item instanceof Coupon) {
                coupons.add((Coupon) item);
            }
        }
        return totalPrice;
    }
}
