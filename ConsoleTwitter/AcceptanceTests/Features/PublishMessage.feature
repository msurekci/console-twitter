Feature: Publish message

Scenario: As a user, I should be able to publish a message
	Given I am on Console Twitter
	When I enter "Alice -> I love the weather today"
	Then "I love the weather today" should be added to Alice's timeline

