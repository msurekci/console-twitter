Feature: Viewing posts

Scenario: As a user, when I enter a users name I should see their posts
	Given I am on Console Twitter
	When I enter "Bob"
	Then I should see Bob's messages/wall

