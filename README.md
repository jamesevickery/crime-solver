# crime-solver
C# program to solve a crime logic puzzle

---

### PROBLEM:

#### After a crime, four suspects were interviewed. Below are their statements. The detectives know that *each told one true statement* and *one false statement*. From the information below, can you tell who committed the crime?

Alex said:

- It wasn't David
- It wasn't Brad

Brad said:

- It wasn't Charlie
- It was David

Charlie said:

- It was Alex
- It wasn't David

David said:

- It was Charlie
- It wasn't Alex

---

### SOLUTION:

Using the program, every combination of true or false for four boolean variables is tested for validity with respect to the statements by the four suspects. If all four `Valid` suspect statments return `true`, the suspect name(s) are written to `Console`.

View [`Program.cs`](https://github.com/jamesevickery/crime-solver/blob/master/CrimeSolver/Program.cs) to see the `C#` implementation.

---

#### Another way of solving the puzzle:

Let 'A' mean 'Alex commited the crime', 'B' means that it was Brad, etc.

From the suspects' statements we can form a proposition:

    ((¬D ∧ B) ∨ (D ∧ ¬B)) ∧
    ((¬C ∧ ¬D) ∨ (C ∧ D)) ∧
    ((A ∧ D) ∨ (¬A ∧ ¬D)) ∧
    ((C ∧ D) ∨ (¬C ∧ ¬D))
    
If we assume that only one suspect commited the crime:

    ((¬D ∧ B) ∨ (D ∧ ¬B)) ∧
    (¬C ∧ ¬D)
    (¬A ∧ ¬D)
    (¬C ∧ ¬D)

Simplified to:

    ¬C ∧ ¬D ∧ ¬A ∧ ((¬D ∧ B) ∨ (D ∧ ¬B))

Finally:

    ¬C ∧ ¬D ∧ ¬A ∧ B

In English, this means: Charlie didn't commit the crime, David didn't commit the crime, Alex  didn't commit the crime, **Brad commited the crime**.

This result is (almost) the same as the program's result. Program output:

    The crime was commited by: Alex, Charlie, David.
    The crime was commited by: Brad.

The program's only answer assuming that only one person commited the crime is `The crime was commited by: Brad.`, although due to the original questions ambiguity (not specifying that only one person commited the crime) it is possible that all suspects *except* Brad commited the crime.
