Feature: Implementimi i nje stive.Do permbaje 
         3 metoda kryesore push(),pop(),top().
@mytag
Scenario: Push element ne Stive
Given  StackSize me madhesi fikse
And    Stack me pak elemente  
When   Ti push nje element te ri 
Then   Count do te rritet me nje
And    Stack do te behet nje element me shume


Scenario: Pop element nga Stiva 
Given    StackSize me madhesi fikse
And      Stack me elemente  
When     Ti pop element nga Stack
Then     Count do te zbritet me nje
And      Stack do te behet nje element me pak

Scenario: Top element nga Stiva
Given   StackSize me madhesi fikse
When    Stack me elemente
Then    Merr keto elemente
And     Kthe keto elemente




