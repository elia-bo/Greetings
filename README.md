# KataGreeting

## Requirement 1

Write a method `greet(name)` that interpolates `name` in a simple greeting. 

Example: when `name` is `"Bob"`, the method should return the string `"Hello, Bob."`.

## Requirement 2

Handle nulls by introducing a stand-in. 

Example: when `name` is null, then the method should return the string `"Hello, my friend."`

## Requirement 3

Handle uppercase names by returning an uppercase greeting.

Example: when `name` is `"JERRY"` then the method should return the string `"HELLO JERRY!"`

## Requirement 4

Handle an array of two names.  

Example: when `name` is `["Jill", "Jane"]`, then the method should return the string `"Hello, Jill and Jane."`

## Requirement 5

Handle arrays of 3 or more names. 

Example: when `name` is `["Amy", "Brian", "Charlotte"]`, then the method should return the string `"Hello, Amy, Brian, and Charlotte."`

## Requirement 6
Handle arrays of mixed case names.

Example: when `name` is `["Amy", "BRIAN", "Charlotte"]`, then the method should return the string `"Hello, Amy and Charlotte. AND HELLO BRIAN!"`

## Requirement 7
Handle arrays of names where a single item in the array contains two names.

Example: when `name` is `["Bob", "Charlie, Dianne"]`, then the method should return the string `"Hello, Bob, Charlie, and Dianne."`.

## Requirement 8
Handle deliberate commas indicated by escaped double quotation marks.

Example: when `name` is ["Bob", "\"Charlie, Dianne\""], then the method should return the string 
`"Hello, Bob and Charlie, Dianne."`.
