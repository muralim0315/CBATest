
Feature: Get a Pet by ID
  In order to retrieve pet details from the store
  As a user
  I want to fetch a pet using the API

  Scenario: Get a pet with valid ID
    Given I have a valid pet ID
    When I get the pet by ID
    Then the response should be successful

  Scenario: Get a pet with invalid ID
    Given I have an invalid pet ID
    When I get the pet by ID
    Then the response should not be successful
