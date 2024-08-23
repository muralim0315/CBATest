
Feature: Upload an Image for a Pet
  In order to associate images with pets in the store
  As a user
  I want to upload images using the API

  Scenario: Upload an image for a valid pet ID
    Given I have a valid pet ID and a valid image
    When I upload the image for the pet
    Then the response should be successful

  Scenario: Upload an image for an invalid pet ID
    Given I have an invalid pet ID and a valid image
    When I upload the image for the pet
    Then the response should not be successful
