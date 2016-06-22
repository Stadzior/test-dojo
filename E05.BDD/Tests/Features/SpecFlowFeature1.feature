Feature: HealthyShopping
	In order to eat healthy
	As a common customer
	I want to do the shopping in a grocery store

@BasicFlow
Scenario: I do regular shopping 
	Given I have 1 kg of apples for 2.5 PLN / kg in the cart 
	And I have 2 loafs of bread for 2.25 PLN / loaf in the cart
	When I go to checkout
	Then I'm asked to pay 7 PLN

Scenario: I'm not buying anything
	Given I have an empty cart
	When I go to checkout
	Then I'm not asked for anything

Scenario: I do a big purchase and expect a discount
	Given I have 1 TV Set for 2500 PLN in the cart 
	When I go to checkout 
	Then I'm given 1.5% discount And I'm asked to pay 2462.5 PLN

Scenario: I buy large number of products and expect a wholesale discount 
	Given I have 100 kg of apples for 2.5 PLN / kg (with wholesale from 20 kg) in the cart 
	When I go to checkout 
	Then I'm offered 3% discount And I'm asked to pay 242.5 PLN
