Feature: BankIDpåMobil
	Simple calculator for adding two numbers

@test_bankid
Scenario: Altinn BankIdPåmobil Login
	Given Launch Chrome browser and Navigate to Altinn page
	When I click Login
	And I click BankIdPåmobil
	And I enter Mobno '09876543' and DOB '090909'	
	Then I should log in
	
@Otherswithrights
Scenario: Altinn Andre med rettigheter via BankIdPåmobil
	Given Launch Chrome browser and Navigate to Altinn page
	When I click Login
	And I click BankIdPåmobil
	And I enter Mobno '09876543' and DOB '090999'
	Then I should log in 
	And I click Profile page
	And I go to OthersWithRights panel
	Then I Click AddpersonorORG button
	And I Enter '09876543' and 'lastname'
	And I click Next 
	When I click ProvidAccess button
	And I select service'Service Name'
	And I submit 'Service Name' button
	And I click submit button
	And I click Give rights button
	Then I click done button

@beomtilgang
Scenario: Altinn Be om tilgang via BankIdPåmobil
	Given Launch Chrome browser and Navigate to Altinn page
	When I click Login
	And I click BankIdPåmobil
	And I enter Mobno '09876543' and DOB '090909'
	Then I should log in 
	And I click Profile page
	And I got to Myrequests panel
	Then I click create new request button
	And I select user 'first last name' in search list
	And I select service 'Service Name' for request and add service
	And I click next and I enter email
	Then I send request and click done 

