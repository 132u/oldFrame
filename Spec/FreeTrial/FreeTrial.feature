@FreeTrial
Feature: FreeTrial
	I want to be able to get to the Free Trial page.
	I want to be able to register on my existing user aacount.
	I want to be able to register as a new user.

@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should display to Free Trial page 
	Given I'm on the Homepage
	And I'm not logged in
	When I enter Free Trial page by Header Component link
	Then Free Trial First Step page should be displayed correctly

@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should stay at first step when credentials are not entered
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration without entering any credentials
	Then there should be You must enter an e-mail address validation message displayed
	Then there should be You must confirm your e-mail address validation message displayed

@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should stay at first step when email confirmation is not set
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration without entering Email confirmation address
	Then there should be You must confirm your e-mail address validation message displayed
	
@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should stay at first step when only confirmation address is entered
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration without entering Email address
	Then there should be You must enter an e-mail address validation message displayed
	Then there should be The email address must be the same validation message displayed
	
@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should stay at first step when email confirmation address is incorrect
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration with invalid email confirmation address
	Then there should be The email address must be the same validation message displayed
	
@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should stay at first step  when existing email with wrong password provided
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration by using existing user email address and invalid password
	Then there should be The password you supplied was incorrect validation message displayed

@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should redirect to step two when valid existing email and password provided
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration by using existing user email address and valid password
	Then I should be redirected to the Free Trial Second Step page
	
@emergingmarkets.org @petroleumeconomist.com @managingip.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should display Free Trial second page correctly
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration by using existing user email address and valid password
	Then I should be redirected to the Free Trial Second Step page
	And Free Trial second page should be displayed correctly

@emergingmarkets.org @petroleumeconomist.com @managingip.com @petroleumeconomist.com
@capacitymagazine.com @hedgefundintelligence.com
Scenario: Free Trial - Should redirect to step two when valid data provided
	Given I'm on the Homepage
	And I'm not logged in
	When I try to get to the step two of registration with correct data
	Then I should be redirected to the Free Trial Second Step page

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should register as a new user when valid data provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user with valid data provided
	Then I should be registered as a new user

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when First name not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing first name
	Then I should not be registered as a new user
	And First Name validator should be diplayed

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Last name not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing last name
	Then I should not be registered as a new user
	And Last Name validator should be diplayed

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
@hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when company name not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing company name
	Then I should not be registered as a new user
	And Company Name validator should be diplayed

@emergingmarkets.org @managingip.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Job title not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing job title
	Then I should not be registered as a new user
	And Job Title validator should be diplayed

@petroleumeconomist.com
Scenario: Free Trial - Should not register new user when Position type not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing position type from the list
	Then I should not be registered as a new user
	And Position type validator should be diplayed

@petroleumeconomist.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Company type not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing company type from the list
	Then I should not be registered as a new user
	And Company type validator should be diplayed

@managingip.com @petroleumeconomist.com @capacitymagazine.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when User title not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing user title
	Then I should not be registered as a new user
	And User Title validator should be diplayed

@managingip.com @petroleumeconomist.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Telephone number not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing telephone number
	Then I should not be registered as a new user
	And Telephone number validator should be diplayed

@managingip.com @petroleumeconomist.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Address not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing address
	Then I should not be registered as a new user
	And Address validator should be diplayed

@petroleumeconomist.com
Scenario: Free Trial - Should not register new user when Address Line Two not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing address line two
	Then I should not be registered as a new user
	And Address line two validator should be diplayed

@managingip.com @petroleumeconomist.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when City not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing city
	Then I should not be registered as a new user
	And City validator should be diplayed

@managingip.com @petroleumeconomist.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Zip not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing zip
	Then I should not be registered as a new user
	And Zip validator should be diplayed

@managingip.com @hedgefundintelligence.com
Scenario: Free Trial - Should not register new user when Country not provided
	Given I'm on the Free Trial Second Step page
	When I try to register as a new user without providing country
	Then I should not be registered as a new user
	And Country validator should be diplayed
