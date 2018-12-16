Feature: ProductDetailPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@PDP
Scenario: User can add product to cart
	Given user opens 'dresses' section
	And opens first product from the list
	And increases quantity to 2
	When user clicks on add to cart buton
	Then product is added to the cart
