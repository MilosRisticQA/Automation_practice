Feature: MyAccount
	In order to use all functionallities
	As a user
	I want to be able to manage my account

@mytag
Scenario: User can log in
	Given user opens sign in page
	And enters correct credentials
	When user submits the login form
	Then user will be logged in


@mytag
Scenario: User can open wishlist page
	Given user opens sign in page
	And enters correct credentials
	Given user submits the login form
	When user opens my wishlist
	Then user can add new wishlist


@MyAccount
Scenario: User can create an account
	Given user opens sign in page
	Given initiates a flow for creating an account
	Given user enters all required personal details
	When submits the sign up form
	Then user will be logged in
	Given user's full name is displayed
	
