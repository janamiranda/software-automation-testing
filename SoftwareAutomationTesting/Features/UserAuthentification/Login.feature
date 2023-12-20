Feature: Login
	As a registered user,
	I want to log into the application,
	So that I can go to private areas of the application.

# Users have the ability to alter the quotes for both login and password, allowing them to create diverse sets of tests
# Input your own credentials as the provided ones were used solely for testing purposes and have already been modified for security reasons
Scenario: User shall be able to submit the login form with the correct credentials
	Given the login page is displayed
	And the correct user "janamiranda@live.com" is entered into the username field
	And the correct password "Abcd123*" is entered into the password field
	When the user invokes the login action
	Then the login is logged in successfully

# This represents a negative scenario, it could also have been achieved by altering the credentials in the scenario above
Scenario: User cannot submit the login form with the wrong credentials
	Given the login page is displayed
	And the user "user" is entered into the username field
	And the password "password" is entered into the password field
	When the user invokes the login action
	Then the message "Invalid username or password" is displayed