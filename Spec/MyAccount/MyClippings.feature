@MyClippings
Feature: MyClippings
	I want to be able to add article to my clippings list.
	I want to be able to remove article from my clippings list.
	I want to be able to use link to the article from my clippings list.

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: My clippings - should be able to add article to clippings when logged in
	Given I'm on the first article page in the News section
	Then I should be able to add article to my clippings

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: My clippings - shouldn't be able add article to clippings when not logged in
	Given I'm not logged in
	When I have entered article in the News section
	Then I shouldn't be able to add article to my clippings

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: My clippings - Should add article to my clippings list
	Given I'm on the first article page in the News section
	When I add article to my clippings list
	Then Article should be added to my clippings list

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: My clippings - Should remove article from my clippings list
	Given I have added article to the my clippings list
	When I enter My Clippings page
	And I delete first article from the my clippings list
	Then first article should be removed

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: My clippings - Should navigate correctly to the article from my clippings list
	Given I have added article to the my clippings list
	When I enter My Clippings page
	And I click on an article from list
	Then the article should be displayed