@Search
Feature: Search
	I want to be able to use search functionality to search requested content on the site.
	I want to be able to perform search by using enter key.
	I want to block search performed by using sql injection.
	I want to block search performed by using string with special characters.
	I want to block search performed by using with white space.

Background:
	Given I'm on the Homepage

@capacityconferences.com @emergingmarkets.org @petroleumeconomist.com @managingip.com
@euromoneyconferences.com 
Scenario: Search - Should not search when no phrase entered
	When I perform search with an empty phrase
	Then Search process shouldn't start

@euromoneytraining.com @capacitymagazine.com 
Scenario: Search - Should display Advanced Search Page when no phrase entered
	When I perform search with an empty phrase
	Then Advanced Search Page should be displayed

@euromoneytraining.com @capacitymagazine.com 
Scenario: Search - Should display Advanced Search page correctly
	When I perform search with an empty phrase
	Then Advanced search page should be displayed correctly

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @euromoneyconferences.com 
Scenario: Search - Should not search when whitespaces entered
	When I perform search with white spaces 
	Then Search process shouldn't start

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @hedgefundintelligence.com
@globaltelecomsbusiness.com
Scenario: Search - Should display search results
	When I perform search with "banking" phrase
	Then Search results page should be displayed

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @euromoneyconferences.com @hedgefundintelligence.com
@globaltelecomsbusiness.com
Scenario: Search - Should display search results page correclty
	When I perform search with "banking" phrase
	Then Search results page should be displayed correctly

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com @capacitymagazine.com @hedgefundintelligence.com @globaltelecomsbusiness.com
Scenario: Search - Should perform search when search executed with enter button
	When I perform search with "banking" phrase and I press enter key
	Then Search results page should be displayed

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com 
Scenario: Search - Should not search when SQL Injection query entered
	When I perform search with SQL injection
	Then Search process shouldn't start

@capacityconferences.com @euromoneytraining.com @emergingmarkets.org @petroleumeconomist.com
@managingip.com 
Scenario: Search - Should not search when special characters entered
	When I perform search with string with special characters 
	Then Search process shouldn't start
