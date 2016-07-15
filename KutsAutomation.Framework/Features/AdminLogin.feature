Feature: As a site Admin 
	I can login to Content Management System
So that i can edit my site


@Login @Critical @admin @LoginSuccess 
Scenario: LoginSuccess 
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		|username           |password|
		|admin@yourstore.com|admin   |
	Then I should be taken to the "Dashboard" Page
	
@Login @Critical @admin @LoginFailure 
Scenario: LoginFailure 
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		| username | password |
		|hetal@yourstore.com|admin|
	Then I should be given an error "LoginFail"

@Login @admin @LoginFailure
Scenario: LoginFailure Wrong Email Format	
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		| username | password |
		|hetal@|admin|
	Then I should be given an error "WrongEmail"

@Login 	
Scenario: RememeberMe 
	Given I am on the "AdminHome" Page 
	When I click on RememberMe 
	And I login with my credentials 
		| username            | password |
		| admin@yourstore.com | admin    |
	Then I should be taken to the "Dashboard" Page
	And I logout
	Given I am on the "AdminHome" Page 
	Then The "admin@yourstore.com" should be the value of the email textbox