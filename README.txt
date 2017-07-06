Roman Numerals Kata

	Stories: 
	As a game developer
	I want to be able to convert a number to a numeral
	So that I can label my game releases using Roman numerals
		Given I have started the converter
		When I enter $number
		Then $numeral is returned

	As a marketing manager
	I want customers to be able to convert numerals to numbers
	So that they can buy the latest version of the game
		Given I have started the converter
		When I enter $numeral
		Then $number is returned

	Solution requirements: 
		Visual Studio
			Nuget
				Nunit
				Specflow


	How to build:

	How to run:

	Thought Process: 
		7/6 aprox 2pm: 
			I began from the smallest numbers (1-3) and then saw my first 'edge' case 4. 
			This is where I started thinking about how to tackle the rule "The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row".
			Currently I am thinking of an enum approach using assignment through the enum to check for special cases such as 4 being IX...essentially 5 - 1.
			Also plenty of name refactoring needed, leaving it as a clean up task for now.
