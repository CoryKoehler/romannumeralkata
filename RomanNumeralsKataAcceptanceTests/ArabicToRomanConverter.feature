Feature: Convert Arabic Number to Roman Numeral
	As a game developer
	I want to be able to convert a number to a numeral
	So that I can label my game releases using Roman numerals

@mytag
Scenario: Accept a numeric input and output the Roman numeral for the input number.
	Given I have started the converter
	When I enter 70
	Then the result should be CXX
