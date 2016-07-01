@SingUp
Feature: SignUp

@euromoneyconferences.com
Scenario: Sign Up - Should sign up to site
	Given I'm on sign up page
	When I submit registration form
	Then I should be registered
