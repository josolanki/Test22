Feature: TMFeature

As a Turnup Portal User 
I like to create, edit and delete time record.
So i can manage employee's time record successfully.

Scenario: Create time record with valid details
	Given I logged into Turnup portal successfully
	When I navigate to Time and Material page  
	And I created new Time record
	Then Record should be created successfully
