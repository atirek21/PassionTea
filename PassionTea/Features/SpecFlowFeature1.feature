Feature: Passion Tea Website
	As a customer of the Passion Tea website
	I can order a product from collection and give feedback
	

	Background: 
	Given I am on the Passion Tea Website

Scenario: User is on the Welcome Page
	Then I am able to see the Welcome Page

Scenario: User buys Red Tea using Visa Card
    Given I go to Herbal Tea Section
	When I select Red Tea 
	And place order
	Then I should see the Order Confirmation Page

Scenario: User buys Green Tea using Visa Card
   Given I go to Herbal Tea Section
   When I select Green Tea 
   And place order
   Then I should see the Order Confirmation Page

Scenario: User Gives Feedback on Let's Talk Tea Page
  Given I click on Let's Talk Tea link in the homepage
  When  I fill the Feedback Form
  Then I submit the Feedback form 
  And  I should see a Feedback Confirmation Page


