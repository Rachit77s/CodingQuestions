public class Coupon extends CartItem{
    private CouponType type;
    private int discountPercentage;
    private String productType;

    public Coupon(CouponType type, int discountPercentage) {
        this.type = type;
        this.discountPercentage = discountPercentage;
    }

    public Coupon(CouponType type, int discountPercentage, int nthItem, String productType) {
        this(type, discountPercentage);
        this.type = type;
        this.productType = productType;
    }

    public CouponType getCouponType() {
        return type;
    }

    public int getDiscountPercentage() {
        return discountPercentage;
    }

    public String getProductType() {
        return productType;
    }
}
