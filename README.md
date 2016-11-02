# crime-solver
C# program to solve a crime logic puzzle

---

### PROBLEM:

#### After a crime, four suspects were interviewed. Below are their statements. The detectives know that *each told one true statement* and *one false statement*. From the information below, can you tell who committed the crime?

Alex said:

- It wasn't David
- It wasn't Brad

Charlie said:

- It was Alex
- It wasn't David

Brad said:

- It wasn't Charlie
- It was David

David said:

- It was Charlie
- It wasn't Alex

---

### SOLUTION:

Using the program, every combination of true or false for four boolean variables is tested for validity with respect to the statements by the four suspects. If all four `Valid` suspect statments return `true`, the suspect name(s) are written to `Console`.
