@Articles
Feature: Articles
	I want to be able to add comment to the article.

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - should display article page correctly
	Given I'm on the first article page in the News section
	Then Article page should be displayed correctly 

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - should be able to add comment when logged in
	Given I'm on the first article page in the News section
	Then I should be able to add comment to the article

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - shouldn't add comment when not logged in
	Given I'm not logged in
	When I have entered article in the News section
	Then I shouldn't be able to add comment to the article

@emergingmarkets.org @petroleumeconomist.com
Scenario: Article - should add comment when all required fields are filled
	Given I'm on the first article page in the News section
	When All required fields on the add comment section are filled
	Then Comment should be added correctly

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - shouldn't add comment when You name textbox is empty
	Given I'm on the first article page in the News section
	When Your name/commenter name is empty
	Then Comment shouldn't be added

@emergingmarkets.org @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - shouldn't add comment when Your email address textbox is empty
	Given I'm on the first article page in the News section
	When Your email address is empty
	Then Comment shouldn't be added

@emergingmarkets.org @managingip.com @petroleumeconomist.com @capacitymagazine.com
Scenario: Article - shouldn't add comment when Your comments textbox is empty
	Given I'm on the first article page in the News section
	When Your comments is empty
	Then Comment shouldn't be added

@capacitymagazine.com @managingip.com
Scenario: Article - shouldn't add comment when captcha is empty
	Given I'm on the first article page in the News section
	When All required fields on the add comment section are filled
	But Captcha field is empty
	Then Comment shouldn't be added