Feature: Create User
	I as a user admin want to create a new user for platform

@sucess
Scenario Outline: Create user with sucess
	Given I'm logged with a user admin
	And I want to create a new user with username "username"
	And the name of user is "name"
	And the user password is "1234abcd"
	And the user type is <type>
	When I create user
	Then the user should be created with success
	And no exceptions should be thrown
	Examples: 
	| Type    |
	| Cashier |
	| Admin   |
	| Manager |

@fail
Scenario Outline: Create user with invalid arguments
	Given I'm logged with a user admin
	And I want to create a new user with username <username>
	And the name of user is <name>
	And the user password is <password>
	And the user type is <type>
	When I create user
	Then the user should not be created
	And an exceptions should be thrown with <exception>
	Examples: 
	| username  | name | password | exception       |
	| *         | name | pass123  | InvalidUsername |
	| username  | *    | pass123  | InvalidName     |
	| usernamee | name | *        | InvalidPassword |

Scenario: Create user without user logged
