Feature: Executeautomation
	Simple calculator for adding two numbers

@mytag
Scenario: Executeautomation test
	Given I navigate to executeautomation 
	When  I click execute automation login
	And Enter username 'admin' and password 'password'
	Then I click submit and user is logged in