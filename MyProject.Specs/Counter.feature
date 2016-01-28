Feature: Counter
	As an author
	I want to know the number of times each word appears in a sentence
	So that I can make sure I'm not repeating myself

@mytag
Scenario: Count words first example
	Given I have entered "This is a statement, and so is this."
	When I run application
	Then the result should be "is 2, this 2, a 1, and 1, statement 1, so 1"

Scenario: Count words second example
	Given I have entered ""
	When I run application
	Then the result should be ""

Scenario: Count words third example
	Given I have entered "21312 2452 123 123!!$$%#$^&$%"
	When I run application
	Then the result should be "21312 1, 2452 1, 123 2"