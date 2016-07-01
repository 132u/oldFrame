Feature: Purchase
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@tradefinancemagazine.com
Scenario Outline: Checkout - Should buy the same amount of subscriptions as selected at first step
	Given I selected one year subscription
	When I select number of subscriptions <Quantity>
	And I register with new email
	And I go to payment page
	Then quantity on should be the same as at the beginning
	When I pay for the subscription
	Then number of purchased subscriptions should be the same on the receipt
	Examples:
	| Quantity |
	| 1        |
	| 5        |
	
@tradefinancemagazine.com
Scenario Outline:  Checkout - Should pay with different credit cards
	Given Given I've selected basic subscription
	When I register with new email
	And I go to payment page
	And I subscribe successfully with following card type <Type> and number <Number> and security number <SecurityNumber> and expiration month <ExpirationMonth> and expirationYear <ExpirationYear>
	Then I should subscribe successfully
	Examples:
	| Type          | Number           | SecurityNumber | ExpirationYear |
	| Visa          | 4929000000006    | 123            | 2020           |
	| MasterCard    | 5555555555554444 | 123            | 2020           |
	| Amex          | 378282246310005  | 1111           | 2020           |
	| JBC           | 3530111333300000 |                | 2020           |
	| Delta         | 4462000000000003 |                | 2020           |
	| Visa Electron | 4917300000000008 |                | 2020           |
	| Maestro Int.  | 5573470000000001 |                | 2020           |