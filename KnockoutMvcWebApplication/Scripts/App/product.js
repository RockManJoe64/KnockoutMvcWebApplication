function ProductOrder(customer, qty, express) {
    var self = this;
    self.customer = ko.observable(customer);
    self.qty = ko.observable(qty);
    self.express = ko.observable(express);
}

function Product(code, name, price, qty) {
    var self = this;
    self.productCode = ko.observable(code);
    self.productName = ko.observable(name);
    self.productPrice = ko.observable(price);
    self.productQty = ko.observable(qty);
    self.productOrders = ko.observableArray([]);

    self.addOrder = function (order) {
        this.productOrders.push(order);
    }
}

function ProductViewModel() {
    var self = this;

    self.currentProduct = ko.observable(new Product("P1", "LED", 45000.00, 100));
    self.currentProduct.addOrder(new ProductOrder("Jane Doe", 100, false));
    
    self.saveProduct = function () {
        var productModel = ko.mapping.toJS(self.currentProduct);
        ko.utils.postJson("/Product/SaveProduct", { product: productModel });
    }
}