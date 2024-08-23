
Feature: Update a Pet with Form Data
  In order to modify pet details in the store using form data
  As a user
  I want to update pets using form data via the API

  Scenario: Update a pet with valid form data
    Given I have a valid pet ID and valid form data
      | name          | status  |
      | TommyUpdated  | pending |
    When I update the pet using form data
    Then the response should be successful

  Scenario: Update a pet with invalid form data
    Given I have an invalid pet ID and valid form data
      | name          | status  |
      | InvalidPet    | pending |
    When I update the pet using form data
    Then the response should not be successful
