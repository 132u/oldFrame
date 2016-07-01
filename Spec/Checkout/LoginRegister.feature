Feature: LoginRegister
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register with invalid email
		Given Given I've selected basic subscription
		When I try to register with invalid email <Email>
		Then Validation message should be displayed
Examples:
		| Email                                                                                                 |
		| test@test.c1om                                                                                        |
		| test@test.comuk                                                                                       |
		| test@test.c                                                                                           |
		| moreThanHundredChars@rtyuioqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop.com |
		| test@eyromoney.fails                                                                                  |
		| test!@#$%^test@euromoney.test                                                                         |