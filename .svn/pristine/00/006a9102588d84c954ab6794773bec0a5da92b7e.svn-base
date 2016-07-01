@SubscriptionRedundancy
Feature: SubscriptionRedundancy

Scenario: Subscribe page - Should display Subscribe page
	Given I'm on the Homepage
	And I'm not logged in
	When I enter Subscribe page by Header Component link
	Then Subscribtion One Step page should be displayed correctly

Scenario: Subscribe page - Should redirect to step two
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of subscription
	Then I should be redirected to the Subscribe Second Step page

Scenario: Subscribe page - Should get subscription by invoice as a new user with valid data provided
	Given I'm on the Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario: Subscribe page - Should get EuroHedge subscription by invoice as a new user with valid data provided
	Given I'm on the EuroHedge Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario: Subscribe page - Should get AsiaHedge subscription by invoice as a new user with valid data provided
	Given I'm on the AsiaHedge Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario: Subscribe page - Should get AbsoluteReturn subscription by invoice as a new user with valid data provided
	Given I'm on the AbsoluteReturn Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario: Subscribe page - Should get AbsoluteUCITS subscription by invoice as a new user with valid data provided
	Given I'm on the AbsoluteUCITS Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario: Subscribe page - Should get InvestHedge subscription by invoice as a new user with valid data provided
	Given I'm on the InvestHedge Subscribe page
	When I try to get subscription by invoice as a new user with valid data provided
	Then I should get subscription as a new user

Scenario Template: Subscribe page - Should get warning mesasge when invalid credit data provided
	Given I'm on the AbsoluteUCITS Subscribe page
	When I try to get subscription by credit card as a new user with valid data provided
	And I fill incorrect data for "<credit_card>"
	Then I should get warning message 'Your order was declined. Please verify your information.'
Examples: 
| credit_card   |
| Amex          |
| JCB           |
| Delta         |
| Visa Electron |
| Maestro Int.  |

Scenario Template: Subscribe page - Should get warning mesasge when invalid number card provided
	Given I'm on the AbsoluteUCITS Subscribe page
	When I try to get subscription by credit card as a new user with valid data provided
	And I fill invalid card number data for "<credit_card>"
	Then I should get warning message about number card
	Examples: 
| credit_card   |
| Amex          |
| JCB           |
| Delta         |
| Visa Electron |
| Maestro Int.  |

Scenario Template: Subscribe page -Check State combobox
	Given I'm on the InvestHedge Subscribe page and select 2nd package
	And state combox is read only
	When I fill all required fields and set "<country>"
	Then warning message appears that State combobox  is required
	Examples: 
	| country       |
	| Canada        |
	| United States |

Scenario:Subscribe page - User can get two product subscriptions
	Given I'm on the InvestHedge Subscribe page
	When I try to get subscription by credit card as a new user with valid data provided
	And I fill all required data for credit card
	Then I should get subscription as a new user
	And open mailtrap
	And find my password
	And I login as user with one subscription
	Given I'm on the AbsoluteUCITS Subscribe page
	When I try to get subscription by credit card as a new user with valid data provided
	Then I should get subscription as a new user

Scenario:Subscribe page - Check that for US country US state combobox contains correct state list
	Given I'm on the AbsoluteUCITS Subscribe page
	When I set US in Country combobox
	Then US State combobox contains correct list

Scenario: Subscribe page - Check that Payment page is displayed correctly for each Country
	When I set country fill another fields