@Footer
Feature: Footer
	I want to be able to verify if footer is displayed.
	I want to be able to use every footer link.

Background:
Given I'm on the Homepage

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @hedgefundintelligence.com
@globaltelecomsbusiness.com
Scenario: Footer - Should display footer
Then the footer should be displayed

@capacityconferences.com @emergingmarkets.org @petroleumeconomist.com @managingip.com
@capacitymagazine.com @euromoneyconferences.com @hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Footer -  Should display copyrights
Then The Copyright should be displayed under the footer

@euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com @managingip.com
@euromoneyconferences.com @hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Footer - Should display About Us page
When I enter About Us page by footer link
Then About Us page is displayed

@euromoneytraining.com @emergingmarkets.org @managingip.com @capacitymagazine.com
@euromoneyconferences.com @hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Footer - Should display Contact Us page
When I enter Contact Us page by footer link
Then Contact Us page is displayed

@emergingmarkets.org @managingip.com @capacitymagazine.com
Scenario: Footer - Should display Sign-up page
When I enter Sign-up page by footer link
Then Sign-up page is displayed

@petroleumeconomist.com
Scenario: Footer - Should display Subscribe page
When I enter Subscribe page by footer link
Then Subscribe page is displayed

@managingip.com
Scenario: Footer - Should display NBO Subscribe page
When I enter Subscribe page by footer link
Then NBO Subscribe page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Feedback page
When I enter Feedback page by footer link
Then Feedback page is displayed

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@capacitymagazine.com @euromoneyconferences.com
Scenario: Footer - Should display Terms and Conditions page
When I enter Terms and Conditions page by footer link
Then Terms and Conditions page is displayed

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@capacitymagazine.com @euromoneyconferences.com
Scenario: Footer - Should display Privacy Policy page
When I enter Privacy Policy page by footer link
Then Privacy Policy page is displayed

@emergingmarkets.org @managingip.com @petroleumeconomist.com @euromoneyconferences.com
@hedgefundintelligence.com
Scenario: Footer - Should display FAQs page
When I enter FAQs page by footer link
Then FAQs page is displayed

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @managingip.com
@petroleumeconomist.com @capacitymagazine.com @euromoneyconferences.com @hedgefundintelligence.com
Scenario: Footer - Should display Cookies page
When I enter Cookies page by footer link
Then Cookies page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Newspaper Archive page
When I enter Newspaper Archive page by footer link
Then Newspaper Archive page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Sponsored Reports page
When I enter Sponsored Reports page by footer link
Then Sponsored Reports page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Economics and Policy page
Given I'm on the Homepage
When I enter Economics and Policy page by footer link
Then Economics and Policy page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Financial Markets page
When I enter Financial Markets page by footer link
Then Financial Markets page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Development page
When I enter Development page by footer link
Then Development page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Middle East & Africa page
When I enter Middle East & Africa page by footer link
Then Middle East & Africa page is displayed


@emergingmarkets.org
Scenario: Footer - Should display Americas page
When I enter Americas page by footer link
Then Americas page is displayed

@emergingmarkets.org @euromoneyconferences.com
Scenario: Footer - Should display Asia page
When I enter Asia page by footer link
Then Asia page is displayed

@emergingmarkets.org @euromoneyconferences.com
Scenario: Footer - Should display Europe page
When I enter Europe page by footer link
Then Europe page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Polls And Awards page
When I enter Polls And Awards page by footer link
Then Polls And Awards page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Events page
When I enter Events page by footer link
Then Events page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Comment And Opinion page
When I enter Comment And Opinion page by footer link
Then Comment And Opinion page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Features page
When I enter Features page by footer link
Then Features page is displayed

@emergingmarkets.org
Scenario: Footer - Should display News page
When I enter News page by footer link
Then News page is displayed

@emergingmarkets.org
Scenario: Footer - Should display Research page
When I enter Research page by footer link
Then Research page is displayed

@emergingmarkets.org
Scenario: Footer - Should display EM View page
When I enter EM View page by footer link
Then EM View page is displayed

@emergingmarkets.org @managingip.com @petroleumeconomist.com @euromoneyconferences.com
@hedgefundintelligence.com
Scenario: Footer - Should display RSS page
When I enter RSS page by footer link
Then RSS page is displayed
