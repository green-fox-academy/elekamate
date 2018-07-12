# TRIAL EXAM: Programming Basics

### Getting Started
 - Fork this repository under your own account
 - Clone the forked repository to your computer
 - Commit your progress frequently and with descriptive commit messages
 - All your answers and solutions should go in this repository

### What can I use?
- You can use any resource online, but **please work individually**
- **Don't just copy-paste** your answers and solutions, use your own words instead.
- **Don't push your work** to GitHub until your mentor announces that the time is up


# Tasks
## 1-4. Complete the following tasks: (~180 mins)

- [Seconds](seconds/Seconds.cs)
- [Count A-s](countas/CountAs.cs)
- [Pirates](pirates/Pirates.cs)
- [Box](box/Box.cs)

### Acceptance criteria
The application is accepted if:
- The solution works according to specification [1p each]
- The solution follows [styleguide](https://github.com/greenfox-academy/teaching-materials/blob/master/styleguide/cs.md) [1p]
- Has proper error handling where the specification says it [1p each]
- Has the correct loops, methods, filters [1p each]
- The code is clean, without unnecessary repetition, and with descriptive names [1p each]
- You commit frequently with descriptive commit messages [1p]

## 5. Question time! (~15 mins) [2p]

### How can you generate a random number? [2p]
#### Your answer:
[As a first step let`s create the random number creating instance: 
Random randomGenerator = new Random();
Then you can generate a random number with the Next method of the Random instance:
Console.WriteLine(randomGenerator.Next(51));

There are multiple overloads for this method:
- Random.Next(Int32);
the only parameter is an exclusive upper bound, the lower bound will be an inclusive 0.
- Random.Next(Int32, Int32);
an inclusive lower bound and an exclusive upper bound.]
