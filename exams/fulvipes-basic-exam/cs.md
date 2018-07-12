# EXAM: Programming Basics

## Getting Started

- Fork this repository under your own account.
- Clone the forked repository to your computer.
- Create a `.gitignore` file so not all your generated files will be committed.
- Commit your progress frequently with descriptive commit messages.
- All your answers and solutions should go into this repository.

### Keep in mind

- You can use any resource online, but **please work individually**!
- **Don't just copy-paste** your answers and solutions, use your own words instead.
- **Don't push your work** to GitHub until your mentor announces that the time is up.

## Tasks

## 1-3. Complete the following tasks

- [Tricky average](tricky-average/TrickyAverage.cs), with the [Test file](tricky-average/TrickyAverageTest.cs)
- [Most productive year](most-productive-year/MostProductiveYear.cs), with sample files [marvel.csv](most-productive-year/marvel.csv) and [paramount.csv](most-productive-year/paramount.csv)
- [Hero battle](hero-battle/HeroBattle.cs), with additional [BaseHero](hero-battle/BaseHero.cs) and [IPunchable](hero-battle/IPunchable.cs)

### Acceptance criteria

The solution is accepted if:

- The solution works according to specification
- The solution follows the [styleguide](https://github.com/green-fox-academy/teaching-materials/blob/master/styleguide/cs.md)
- Has proper error handling where the specification requires it
- Has the correct loops, methods, filters
- The code is clean, without unnecessary repetition, and with descriptive names
- You commit frequently with descriptive commit messages

## 4. Question time! (~10 mins) [2p]

### What is a NullReferenceException?  [1p]

It happens when there is a reference to a null object. Null does not exist so it is impossible to refer to nothing.


### Write an example where you would get a NullReferenceException. [1p]
#### For example you have already declared a list:
List<int> exampleList;
#### You fill the list according to a condition:
if (false)
{
    exampleList = new List<int>();
}
#### And you try to fill it`s element, which does not exists, because the condition was false.
exampleList[0] = 2;
