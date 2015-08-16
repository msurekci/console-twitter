Feature: Following users

Scenario: As a user, I should see the messages of the person I follow
	Given I am on Console Twitter
	When Charlie follows Alice
	And Charlie wants to see his wall
	Then he should see both his own and Alice's wall.

Scenario: As a user, I should see the messages of all the people I follow
	Given I am on Console Twitter
	When Charlie follows Alice
	And Charlie follows Bob
	Then he should see both his own, Alice's and Bob's wall.
