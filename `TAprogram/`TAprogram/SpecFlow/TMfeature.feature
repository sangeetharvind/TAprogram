@smoke @bvt @regression @IC1238
Feature: TMfeature

As a TurnUpPortal admin user
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

Background: 
Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page

@regression
Scenario: 1 create time record with valid data
	When I create a time record
	Then the record should be created successfully
	
@bvt
Scenario Outline: 2 edit existing time record with valid data
	When I update the '<Code>' , '<Description>' and '<Price>' on an existing Time record
	Then the record should have the updated '<Code>' , '<Description>' and '<Price>' successfully

	Examples: 
	| Code             | Description              | Price |
	| Industry Connect | This is Industry Connect | $1.00   |
	| TA Job Ready     | This is TA Job Ready     | $2.00   |
	| EditedRecord     | This is EditedRecord     | $3.00   |

@smoke @bvt @regression
Scenario: delete existing time record
	When I delete an existing record
	Then the record should not be present