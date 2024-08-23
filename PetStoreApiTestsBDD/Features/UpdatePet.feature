
Feature: Update an Existing Pet
  In order to modify pet details in the store
  As a user
  I want to update pets using the API

  Scenario: Update a pet with valid data
    Given I have the following updated pet data
      | id    | name  | status |
      | 12345 | Tommy | sold   |
    When I update the pet in the store
    Then the response should be successful

  Scenario: Update a pet with invalid status
    Given I have the following updated pet data
      | id    | name  | status       |
      | 12345 | Tommy | invalidStatus |
    When I update the pet in the store
    Then the response should not be successful
