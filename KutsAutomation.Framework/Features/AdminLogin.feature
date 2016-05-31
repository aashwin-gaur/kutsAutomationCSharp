Feature: As a site Admin 
	I can login to Content Management System
So that i can edit my site


@Login @Critical @admin @LoginSuccess 
Scenario: LoginSuccess 
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		|correctusername|correctpassword|
	Then I should be taken to the "Dashboard" Page
	
@Login @Critical @admin @LoginFailure 
Scenario: LoginFailure 
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		|wrongusername|wrongpassword|
	Then I should be given an error 
	
	
@Login 	
Scenario: RememeberMe 
	Given I am on the "AdminHome" Page 
	When I login with my credentials 
		|correctusername|correctpassword|     
	And I click on RememberMe 
	Then I close the browser 
	When I Reopen the browser 
	Given I am on the "AdminHome" Page 
	Then The "correctusername" should be the value of the email textbox