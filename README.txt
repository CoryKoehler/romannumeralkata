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
				MOQ

	How to build:

	How to run:

	How to run test:
		Command Line:
		Via Visual Studio:
			mstest:
			resharper:

	Thought Process: 
		7/6 
		2pm: 
			I began from the smallest numbers (1-3) and then saw my first 'edge' case 4. 
			This is where I started thinking about how to tackle the rule "The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row".
			Currently I am thinking of an enum approach using assignment through the enum to check for special cases such as 4 being IX...essentially 5 - 1.
			Also plenty of name refactoring needed, leaving it as a clean up task for now.
		3pm: 
			realizing I need to extract out the subtractive elements i.e IX. Elsewise I will end up with a huge switch case.
			Thinking I can add flag to my enum and and use the enum more generically so thousands, hundreds, tens, ones will have their special cases stored in different flags.
		3:40:
			realized enum wont solve many of the looping problems while handling special cases...thinking I will need to get away from using loops to clean up code.
		4:00:
			I'm stupid, enums are great, dont need flag unless I change away from loops - needed to make sure that array of numbers i had matched the enum. It didn't that is why i was getting stack traces...
			currently solution working except for duplication of numerals i.e III.
			but I really like how clean the enum casting is...not sure how performant over just having two hard coded arrays right up front...but whatever
		4:15: 
			was able to solve duplication of numerals by removing the internal method to bring the while loop up to the top where i could limit the appending.
		5:15: 
			creating specflow test to showcase acceptance test and moq. I do realize that this is a really poor example of moq and it is being used improperly.
			implemented microservice-esque handler to demonstrate moq, and dependcy injection with specflow.
		6:40
			adding another method to handler for roman to arabic converter for second part of kata
		7/17 
		9:30am: 
			Getting back into this had to review what I had already...going to add test for the conversion handler, romanToArabicConverter and implement logic for that.
			After having good code coverage and working product will switch over to api implementation so I can call from the website. Not sure on how I am going to switch over implementations yet