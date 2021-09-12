Feature: AlternativeLogin
	Simple calculator for adding two numbers

@testalternative
Scenario: Altinn Alternative Login
      Given Launch Chrome browser and Navigate to Testenvironment
	  When I click login 
	  And I click Alternative login 	  
	  And I enter SSN '01094731042' and PinOne '12345'
	  And I Submit_FirstPin	  
	  And I enter PinTwo '12345'
	  And I Submit_SecondPin
	  Then I should Log in


Scenario: Instantiate Reporting service and submit service
      Given Launch Chrome browser and Navigate to Testenvironment
	  When I click login 
	  And I click Alternative login 
	  And I enter SSN '01094731042' and PinOne '12345'
	  And I Submit_FirstPin	  
	  And I enter PinTwo '12345'
	  And I Submit_SecondPin
	  Then I should Log in
	  When I navigate to available services
	  And I select 'Acc Security Level 2 Mag' service and service type 'Reporting'
	  And I activate service, click continue with user,continue with form/service
	  And I fill 'Vanitha Seeralan','Lørenskog','1461','Lørenskog'out page one
	  And I fill out page two
	  When I click controll skjema
	  And I close popup alert box and click continue to sign and submit form
	  Then  I Logout and close browser

