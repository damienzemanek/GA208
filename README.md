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
- Q6: Both are arguments, meant to pass in values to a method
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

- Scalar: Single Mathematical Value
- Q: Which one of these lines of code will move the object relative to the world, and why?
- A: `transform.position += moveAmount;`
- Explanation: transform.position is the world-relative Vector3 position of any given GameObject's transform. Meaning any mutations done to transform.position will act on the world-relative.

### Activity 2: Vectors & animation
- Q: Step 2 of your Muskrat code, why does your new line of code move the Muskrat forward correctly? Use the vocab term "coordinate space".
- A: My line of code moves the Muskrat forward correctly because I am correctly mutating the local-offsetted co-ordinate space of the Muskrat's Transform component instead of the global position by using `transform.Translate(...)` and using my local move vector as the parameter.

# W5

### Activity 1: Lecture Notes

- Model (Data) ←— stewards — Controller (logic) ←— Listens to —- View (aesthetics/results)
-Model: Game data
- View: Visuals & results, sound, ui, animations, Subs to controller events and reacts to changes
- Controller: pure game logic, battles, points, branching dialouge

### Activity 3: MG4 Breakdown
<img width="859" height="617" alt="MG4 Breakdown" src="https://github.com/user-attachments/assets/684e2e88-611d-4c70-824e-d985f6183832" />


# W6

### Activity 1: Lecture Notes
- Quizzes have 2 attempts

### Activity 2: Abstract classes & Interfaces
Q: What do you think of the design of these interfaces and abstract classes? Would you keep it the same, or change it, if you were building a project with items like these?
A: I like the design of the interfaces and abstract classes. The use of the interface matches well with its intended outcome. Keeping breakability separate from an abstract I think is a good thing to do because it lends more towards composition over inheritance. Breakable is a functionality that is not very extensive and in-depth and perfectly fits with a compositional concrete implementation. Yes, I would keep the classes the same if I was building a project with items like these. However, as soon as the compositionality of the Items in respect to the amount of interfaces there are available increases to over 5, I would change to data-driven composition.

