Feature: TMfeature

As a TurnUpPortal admin user
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

@regression
Scenario: 1 create time record with valid data
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	And I create a time record
	Then the record should be created successfully
	
Scenario Outline: 2 edit existing time record with valid data
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	When I update the '<Code>' and '<Description>'on an existing Time record
	Then the record should have the updated '<Code>' and '<Description>'

	Examples: 
	| Code             | Description              |
	| Industry Connect | This is Industry Connect |
	| TA Job Ready     | This is TA Job Ready     |
	| EditedRecord     | This is EditedRecord     |