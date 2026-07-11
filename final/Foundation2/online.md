# Class Diagram
``` mermaid
classDiagram

class Product {
    -string _name
    -string _productId
    -double _pricePerUnit
    -int _quantity
    +GetTotalCost() double
}

class Address {
    -string _streetAddress
    -string _city
    -string _stateProvince
    -string _country
    +IsInUSA() bool
    +GetFullAddress() string
}

class Customer {
    -string _name
    -Address _address
    +LivesInUSA() bool
}

class Order {
    -List~Product~ _products
    -Customer _customer
    +AddProduct(product) void
    +CalculateTotalCost() double
    +GetPackingLabel() string
    +GetShippingLabel() string
}

Customer *-- Address
Order *-- Customer
Order *-- Product

```