
Feature: Add a Pet to the Store
  In order to manage pets in the store
  As a user
  I want to add pets using the API

  Scenario: Add a new pet with valid data
    Given I have the following pet data
      | id    | name  | status    |
      | 12345 | Tommy | available |
    When I add the pet to the store
    Then the response should be successful

  Scenario: Add a new pet with missing data
    Given I have the following pet data
      | id    | name  | status |
      |       |       |        |
    When I add the pet to the store
    Then the response should not be successful
