
Feature: Delete a Pet
  In order to remove pets from the store
  As a user
  I want to delete pets using the API

  Scenario: Delete a pet with valid ID
    Given I have a valid pet ID
    When I delete the pet
    Then the response should be successful

  Scenario: Delete a pet with invalid ID
    Given I have an invalid pet ID
    When I delete the pet
    Then the response should not be successful
