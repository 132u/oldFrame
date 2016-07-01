@NewsletterPreferences
Feature: Newsletter preferences
	I want to be able to change my newsletter preferences.

Background:
	Given I'm on the Newsletter Preferences page

@emergingmarkets.org @capacitymagazine.com
Scenario: My account - Should Sign Up for News Alerts
	When I sign up for News Alerts Newsletter
	Then Update successful message should be displayed
	When I go back to newsletter preferences
	Then Newsletter sign up is saved

@emergingmarkets.org @capacitymagazine.com
Scenario: My account - Should Sign Out from News Alerts
	When I sign up for News Alerts Newsletter
	Then Newsletter sign up is saved
	When I sign out from News Alerts Newsletter
	Then Newsletter sign out is saved

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com
Scenario: My account - Should Choose Html version of email format
	When I sign up for News Alerts Newsletter
	And I choose Html version of email format and save
	Then Html version of email format is saved

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com
Scenario: My account - Should Choose Text version of email format
	When I sign up for News Alerts Newsletter
	And I choose Text version of email format and save
	Then Text version of email format is saved
	
@petroleumeconomist.com
Scenario: My account - Should Sign Up for Petroleum Economist Monthly Magazine Update
	When I sign up for Petroleum Economist Monthly Magazine Update Newsletter
	Then Monthly Magazine Update Newsletter sign up is saved
	
@petroleumeconomist.com
Scenario: My account - Should Sign Up for Petroleum Economist Breaking News
	When I sign up for Petroleum Economist Breaking News Newsletter
	Then Breaking News Newsletter sign up is saved
	
@petroleumeconomist.com
Scenario: My account - Should Sign Up for Petroleum Economist Blog Email
	When I sign up for Petroleum Economist Blog Email
	Then Blog Email sign up is saved	

@petroleumeconomist.com
Scenario: My account - Should Sign Out from Petroleum Economist Monthly Magazine Update
	When I sign out from Petroleum Economist Monthly Magazine Update Newsletter
	Then Monthly Magazine Update Newsletter sign out is saved
	
@petroleumeconomist.com
Scenario: My account - Should Sign Out from Petroleum Economist Breaking News
	When I sign out from Petroleum Economist Breaking News Newsletter
	Then Breaking News Newsletter sign out is saved
	
@petroleumeconomist.com
Scenario: My account Should Sign Out from Petroleum Economist Blog Email
	When I sign out from Petroleum Economist Blog Email
	Then Blog Email sign out is saved