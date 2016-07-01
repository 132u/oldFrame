@Login
Feature: Login
	I want to be able to login to the user account.
	I want to be able to logout from the user account.

Background:
	Given I'm on the Login Page

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should display login page correctly
	Then  Login page should be displayed correctly

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should login with correct credentials
	When I login successfully
	Then I should be logged in to user account

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should fail to login with incorrect user name and correct password
	When I try to login with incorrect username
	Then I shouldn't be logged in to user account

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should fail to login with correct user name and incorrect password
	When I try to login with incorrect password
	Then I shouldn't be logged in to user account

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should fail to login with incorrect user name and password
	When I try to login with incorrect username and password
	Then I shouldn't be logged in to user account

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @indmin.com
@hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Login - Should logout successfully
	When I login successfully
	Then I should be logged in to user account
	When I logout correct
	Then I should be logged out from the user account