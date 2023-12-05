# Luhn algorithm
The Luhn algorithm or Luhn formula, also known as the "modulus 10" or "mod 10" algorithm,
named after its creator, IBM scientist Hans Peter Luhn, is a simple check digit formula
used to validate a variety of identification numbers.

## How it works
The Luhn's algorithm, as implemented in the provided C# code, is designed to validate credit card numbers. The algorithm follows these steps:
- Split the Card Number:

The input credit card number is first split into individual digits, and the digits are stored in reverse order.
-  Sum the Odd Digits:

The algorithm calculates the sum of the digits at odd positions (1-indexed) in the reversed array.
-  Sum the Even Digits with Doubling:

For digits at even positions (1-indexed), each digit is doubled. If the doubled value is greater than or equal to 10, the individual digits of the result are summed. Otherwise, the doubled value is directly added to the sum.
- Check Validity:

The sums of odd and even digits are then added together. If the total sum is divisible by 10, the credit card number is considered valid according to Luhn's algorithm.
Return Validation Result:

The Check method returns true if the total sum is divisible by 10, indicating a valid credit card number. Otherwise, it returns false for an invalid credit card number.

In summary, Luhn's algorithm uses a combination of doubling and summing individual digits to create a checksum. The algorithm aims to ensure that the total sum of the digits, after certain operations, is a multiple of 10 for a given credit card number to be considered valid.