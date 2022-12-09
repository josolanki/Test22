Feature: TMFeature

As a Turnup portal user 
I would like to create, edit, delete time records.
so that i can manage employee time successfully



Scenario: Create Time record with valid details
	Given I logged into Turnup Portal
	When I navigate to Time and material page
	And  I create new Time record
	Then The reocrd should be created successfully

Scenario Outline: Edit existing time record with valid details
Given I logged into Turnup Portal page successfully
When I updated '<Description>' on and exsiting time record
Then  I update '<Description>', '<Code>', '<Price>' on an existing time record

Examples:
 | Descrtiption   | Code  | Price |
 | Time           |Jo     | 100   |      |
 | Material       |wire   | 200   |
 |EditRecord      |Mouse  |1200   |