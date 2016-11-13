# Fuzzy Logic Inference
![pl_gif](https://cloud.githubusercontent.com/assets/5732023/20246236/0b06d02e-a9b3-11e6-9b5e-89a0f5d6e547.gif)

This project was created as an academic excercise related to fuzzy logic inference (Inteligent Calculation Methods on Warsaw University of Technology).

The application is split into two modules:

1. InferenceLibrary - a module containing all classes required for performing the inference.

- Uses trapezoid membership functions with multiple configuration options (Inverted trapezoid, possibility to include/exclude border values, possibility to use infinite left/right ranges)
- Performs deffuziffication using Mean of Maxima method
- Allows defining fuzzy rules and optionally: negate conditions, define join operator (or/and)
- Allows displaying all inference steps thanks to the `InferenceDetails` class
- Allows loading a custom xml file thanks to the `InferenceFactory` class

Here's a class diagram of the library:
![classdiagram1](https://cloud.githubusercontent.com/assets/5732023/20246110/276b7222-a9b0-11e6-802a-30ea9a39121d.png)

An example inference process can be found in the integration tests directory.

2. Windows forms application - application that uses the InferenceLibrary module for performing and displaying the inference details

* Allows setting membership functions ranges and draws their charts
* Displays all defined rules in a human readable format
* Shows all inference process - fuzzification, rules evaluation and aggregated membership chart together with a defuzzification result
