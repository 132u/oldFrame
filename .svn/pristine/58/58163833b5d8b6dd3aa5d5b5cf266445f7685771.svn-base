@ChangePassword
Feature: ChangePassword
	I want to be able to change my password.

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com
Scenario: My account NCU - Should display validation messages when trying to change password without entering any data
	Given I'm on the My Account Change Password page
	When I try to change password without entering any data to the textboxes
	Then there should be Please enter your old password validation messages displayed
	Then there should be Please enter your new password  validation messages displayed
	Then there should be Please confirm your new password validation messages displayed

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com
Scenario: My account NCU - Should display validation message when entered incorrect old password
	Given I'm on the My Account Change Password page
	When I try to change password by using incorrect old password
	Then there should be The details you have provided are invalid. Please re-enter and try again message displayed

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com
Scenario: My account NCU - Should not change password when password confirmation is not the same
	Given I'm on the My Account Change Password page
	When I try to change password by using incorrect confirmation password
	Then there should be Your new passwords do not match validation messages displayed

@managingip.com
Scenario: My account NBO - Should display validation messages when trying to change password without entering any data
	Given I'm on the My Account Change Password page
	When I try to change password without providing any data to the textboxes
	Then there should be "You must enter your old password" validation message displayed
	Then there should be "You must enter a new password" validation message displayed
	Then there should be "You must confirm your new password" validation message displayed

@managingip.com
Scenario: My account NBO - Should display validation message when entered incorrect old password
	Given I'm on the My Account Change Password page
	When I try to change password by using incorrect old password
	Then there should be The old password is not correct message displayed

@managingip.com
Scenario: My account NBO - Should not change password when password confirmation is not the same
	Given I'm on the My Account Change Password page
	When I try to change password by providing incorrect confirmation password
	Then there should be "The new passwords must match" validation message displayed

@managingip.com
Scenario: My account NBO - Should change password when correct input provided
	Given I've created a new account
	And I'm on the My Account Change Password page
	When I change my password correctly
	Then Password Updated message is displayed

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com
Scenario: My account NCU - Should change password when correct input provided
	Given I've created a new account
	And I'm on the My Account Change Password page
	When I change my password correctly
	Then Password Updated page is displayed

	@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com
Scenario: My account NCU - Should display passoword updated page correctly
	Given I've created a new account
	And I'm on the My Account Change Password page
	When I change my password correctly
	Then Password Updated pageshould be displayed correctly