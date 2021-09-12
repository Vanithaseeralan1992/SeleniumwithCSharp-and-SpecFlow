Feature: OrangeHRM
	Simple automation with Oramge HRM

@mytag
Scenario: Orange HRM page loging
	Given Launch chrome browser
	And Navigate to OrgangeHRM Page
	When I click Contactsales button	
	And Fill the fields 'FirstName' , 'SecondName' and 'CompanyName' 
	And Select The Element for number of employees group 16 to 20
	And Fill 'JobTitle', '97380179' and 'vanithaseeralangmail.com' details
	And Select Country Norway and fill comment section 
	Then Scroll down and submit 