Feature: Test
	As an author
	I want to know the number of times each word appears in a sentence
	So that I can make sure I'm not repeating myself

@mytag
Scenario: Count words
	Given a sentence "This is a statement, and so is this."
	When the program is run
	Then I'm returned a distinct list "is 2 this 2 a 1 and 1 so 1 statement 1"
