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
				<package id="Castle.Core" version="4.1.0" targetFramework="net452" />
				<package id="Moq" version="4.7.63" targetFramework="net452" />
				<package id="NUnit" version="3.7.1" targetFramework="net452" />
				<package id="Newtonsoft.Json" version="10.0.3" targetFramework="net452" />
				<package id="SpecFlow" version="2.2.0" targetFramework="net452" />
				<package id="SpecFlow.NUnit" version="2.2.0" targetFramework="net452" />

	How to build:
		open the project in visual studio and press ctl + b

	How to run:
		this doesn't run yet...waiting to implement the handler as webapi
		should just be running the webapi class library through local or IIS then following webapp steps to run that locally which will call the api.

	How to run test:
		Command Line:
			nunit console: nunit3-console.exe to run tests from the command line
			nunit3-console.exe path\to\repo\bin\debug\RomanNumeralsKataTests.dll
			for my local the command is nunit3-console.exe E:\repos\RomanNumeralsKata\RomanNumeralsKata\bin\Debug\RomanNumeralsKata.dll
			results are saved into the TestResult.xml file by default from where you ran the cmd at

		Via Visual Studio:
			nunit runner: will need to download the nunit runner -> quick launch search nuget select manage package for solution, then search nunit and install NUnit3TestAdapter
				ctl r + t (web link to extesnion https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter)
			resharper: ctl u + l whilst in visual studio once resharper is installed - you can get free trial versions for 30 days from their website.

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
		11:50am:
			getting back to this again after lunch. decided to get away from enum and just map the basic digits for romantoarabic implementation. just loops through each character of
			the roman numeral string and see if the number associated via the dictionary with the numeral should be added or subtracted for the total. 
			





