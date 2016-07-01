@Validation
Feature: Validation

@hedgefundintelligence.com
Scenario Template: Email Validation -Invalid values
	Given I fill "<invalidEmailValue>" in email field, press Next button
	Then warnings appears
Examples: 
| invalidEmailValue                |
| 123first@s.we1p                  |
| 123first@s.wepok                 |
| 123firstshsdh8989dshsdhdfhdfs.we |

@hedgefundintelligence.com
Scenario: Email Validation -Empty email
	Given I don't type value in email field, press Next button
	Then warning message that email and compare email are empty appears 

@hedgefundintelligence.com
Scenario Template: Textbox Validation -Invalid values
	Given I'm on the AU Subscribe page and select 1st package
	When I fill "<invalid value>" in "<field>", press Next button
	Then Warning message for "<field>" appears
	Examples: 
| invalid value | field       | 
| όμικρον№%     | FirstName   |
| 1Test         | FirstName   | 
| "άλφα         | FirstName   |
| όμικρον№%     | LastName    |
| 1Test         | LastName    |
| "άλφα         | LastName    |
| -άλφα         | CompanyName |

@hedgefundintelligence.com
Scenario Template: Textbox Validation -Empty values
	Given I'm on the AU Subscribe page and select 1st package
	When I don't fill  in "<field>", press Next button
	Then Warning message empty value for "<field>" appears
	Examples: 
| field       |
| FirstName   |
| LastName    |
| CompanyName |
| Zip         |
| City        |