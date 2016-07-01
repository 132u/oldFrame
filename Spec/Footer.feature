Feature: Footer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Footer is displayed
Given I'm on the Home page
Then the footer should be displayed

@mytag
Scenario: Logo on the homepage is displayed
Given I'm on the Home page
Then I should be able to see logo of the site
