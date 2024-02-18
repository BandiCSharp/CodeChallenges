# CodingChallenges Solutions (.NET)
This repository hosts my .NET solutions to various coding challenges found on the Coding Challenges platform (https://codingchallenges.fyi).

# .NET WC Solution

This repository contains my .NET implementation of a simplified `wc` command-line tool, inspired by the Coding Challenges exercise ([https://codingchallenges.fyi/challenges/challenge-wc](https://codingchallenges.fyi/challenges/challenge-wc)). 

## Features

* **Line counting:** Calculates the number of lines in a file.
* **Word counting:** Calculates the number of words in a file (basic word separation).
* **Character counting:** Calculates the number of characters in a file.

## Usage

**Prerequisites**

* .NET Runtime (version specified in your project file)

**Run the Project**

1. Clone this repository:
   ```bash
   git clone https://github.com/[your-username]/my-dotnet-wc
   ```
2. Navigate to the project directory:
   ```bash
   cd my-dotnet-wc
   ```
3. Build and run:
   ```bash
   dotnet build
   dotnet run [options] <filename>
   ```

**Options**

* `-l`: Display line count.
* `-w`: Display word count.
* `-c`: Display character count.

**Example**

```bash
dotnet run -w -c text_sample.txt
```

## Contributing

While contributions are welcome, this project mainly serves as a demonstration of my solution to the Coding Challenges exercise. Feel free to fork and enhance it for your own use! 
