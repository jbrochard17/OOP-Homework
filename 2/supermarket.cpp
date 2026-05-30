#include <iostream>
#include <vector>
#include <string>

double TAX_RATE = 0.07; 

class Product{
    public:
    int id;
    std::string name;
    double price;

    Product(int i, std::string n, double p){
        id = i;
        name = n;
        price = p;
    }

};

class Catalog{
    public:
    std::vector<Product> products;

    void load_catalog() {
        products.push_back({1, "Apple", 0.5});
        products.push_back({2, "Bread", 1.5});
        products.push_back({3, "Milk", 2.0});
        products.push_back({4, "Chocolate", 1.0});
    }

    Product* find_product(int id) {
        // A range-based for loop (C++11+).
        // auto is a type placeholder
        // auto &p declares p as a reference to each element (not a copy)
        for (auto &p : products) if (p.id == id) return &p;
        return nullptr;
    }
};

class Cart{
    public:
    std::vector<int> ids;
    std::vector<int> qty;

    void add_to_cart(int id, int qt) {
        for (size_t i=0;i<ids.size();++i) {
            if (ids[i] == id) { qty[i] += qt; return; }
        }
        ids.push_back(id);
        qty.push_back(qt);
    }
};

class Checkout{
    public:
    Catalog catalog;
    Cart cart;
    double compute_subtotal() {
        double s = 0.0;
        for (size_t i=0;i<cart.ids.size();++i) {
            Product* p = catalog.find_product(cart.ids[i]);
            if (p) s += p->price * cart.qty[i];
        }
        return s;
    }

    double apply_discounts(double subtotal) {
        // silly discount: 10% off if subtotal > $10
        if (subtotal > 10.0) return subtotal * 0.9;
        return subtotal;
    }
};

class ReceiptPrinter{
    public:
    Checkout checkout;

    void print_receipt() {
        std::cout << "---- Receipt ----\n";
        for (size_t i=0;i<checkout.cart.ids.size();++i) {
            Product* p = checkout.catalog.find_product(checkout.cart.ids[i]);
            if (!p) continue;
            std::cout << p->name << " x" << checkout.cart.qty[i] << " @ " << p->price
                    << " = " << (p->price * checkout.cart.qty[i]) << "\n";
        }
        double subtotal = checkout.compute_subtotal();
        double after_discount = checkout.apply_discounts(subtotal);
        double tax = after_discount * TAX_RATE;
        double total = after_discount + tax;
        std::cout << "Subtotal: " << subtotal << "\n";
        std::cout << "Discounted: " << after_discount << "\n";
        std::cout << "Tax: " << tax << "\n";
        std::cout << "Total: " << total << "\n";
        }
};

int main(){
    ReceiptPrinter printer;
    printer.checkout.catalog.load_catalog();
    printer.checkout.cart.add_to_cart(1, 4);   // 4 apples
    printer.checkout.cart.add_to_cart(2, 1);   // 1 bread
    printer.checkout.cart.add_to_cart(4, 3);   // 3 chocolate
    printer.print_receipt();
    return 0;
}