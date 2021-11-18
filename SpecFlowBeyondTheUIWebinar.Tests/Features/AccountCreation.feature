Feature: AccountCreation
As a ParaBank client
I want to be able to open a new account
So I can manage my finances more efficiently

@db
Scenario: Successfully opening a new account
	Given user John is ready to open a new account
	When they open a new checking account
	Then the new account is included in their list of accounts
