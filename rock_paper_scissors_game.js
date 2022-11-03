const getUserChoice = (userInput) => {
  userInput = userInput.toLowerCase();
  if (
    userInput === "rock" ||
    userInput === "paper" ||
    userInput === "scissors" ||
    userInput === "bomb"
  ) {
    return userInput;
  } else {
    console.log("Error, please type either rock, paper or scissors.");
  }
};

const getComputerChoice = () => {
  const randomNumber = Math.floor(Math.random() * 3);
  switch (randomNumber) {
    case 0:
      return "rock";
    case 1:
      return "paper";
    case 2:
      return "scissors";
  }
};

const determineWinner = (userChoice, computerChoice) => {
  if (userChoice === computerChoice) {
    return "This game is a tie!";
  }
  if (userChoice === "rock") {
    if (computerChoice === "paper") {
      return "Computer wins!";
    } else {
      return "You win!";
    }
  }

  if (userChoice === "paper") {
    if (computerChoice === "scissors") {
      return "Computer wins!";
    } else {
      return "You win!";
    }
  }

  if (userChoice === "scissors") {
    if (computerChoice === "rock") {
      return "Computer wins!";
    } else {
      return "You win!";
    }
  }

  if (userChoice === "bomb") {
    return "You win!";
  }
};

const playGame = () => {
  const userChoice = getUserChoice("bomb");
  const computerChoice = getComputerChoice();
  console.log(`You threw: ${userChoice}`);
  console.log(`Computer threw: ${computerChoice}`);

  console.log(determineWinner(userChoice, computerChoice));
};

playGame();
