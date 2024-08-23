
Feature: Find Pets by Status
  In order to filter pets by their status in the store
  As a user
  I want to search for pets using the API

  Scenario: Find pets by status "available"
    Given I have the status "available"
    When I search for pets by status
    Then the response should be successful

  Scenario: Find pets by status "sold"
    Given I have the status "sold"
    When I search for pets by status
    Then the response should be successful

  Scenario: Find pets by invalid status
    Given I have an invalid status "invalid"
    When I search for pets by status
    Then the response should not be successful
