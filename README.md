
# GA208
### Damien Zemanek
# W1
### Activity 1
<hr>

- Q1: 10
- Q2: 2
- Q3: prints: hello world
- Q4: Monobehaviour
- Q5: prints: x = 10
- Q6: Both are arguements, meant to pass in values to a method
- Q7: Transform is wrong, will not compile due to Translate being an instance method
- Q8: Transform should be replaced with either _playerTransform or transform depending on the context

### Activity 2
<hr>

[Google Doc Link Activity 2](https://docs.google.com/document/d/1RHdwQ6bJwzm1yvrqXCDy2VgBkrWVfvVI6CLvcCByLD8/edit?usp=sharing)

<img width="600" height="440" alt="a graphic breakdown of MG1" src="https://github.com/damienzemanek/GA208/blob/main/W1Script2.png?raw=true" />


# W2

### Activity 1 - Notes
- `static` keyword does not require an instance

### Activity 2 - MG-2 Breakdown

<img width="2304" height="1296" alt="MG2 Breakdown4" src="https://github.com/user-attachments/assets/106f8afd-86fe-4a36-94cd-289344bdc19e" />


# W3

### Activity 1 - Notes

- States in a state machine are mutually exclusive

### Activity 4 - MG-3 Breakdown

<img width="2304" height="1296" alt="sdadsad" src="https://github.com/user-attachments/assets/291e4c5e-fbce-4bb1-a17f-6b5fa9ec8eda" />


# W4

### Activity 1: Lecture Notes

Scalar: Single Mathematical Value
Q: Which one of these lines of code will move the object relative to the world, and why?
A: `transform.position += moveAmount;`
Explanation: transform.position is the world-relative Vector3 position of any given GameObject's transform. Meaning any mutations done to transform.position will act on the world-relative.

### Activity 2: Vectors & animation
Q: Step 2 of your Muskrat code, why does your new line of code move the Muskrat forward correctly? Use the vocab term "coordinate space".
A: My line of code moves the Muskrat forward correctly because I am correctly mutating the local-offsetting co-ordinate space of the Muskrat's Transform component instead of the global position by using `transform.Translate(...)` and using my local move vector as the parameter.






