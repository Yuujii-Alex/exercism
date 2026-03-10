export function format(name: string, number: number): string {
  const lastTwo = number % 100;
  const lastOne = number % 10;

  let ending: string;

  if (lastTwo >= 11 && lastTwo <= 13) {
    ending = "th";
  } else if (lastOne === 1) {
    ending = "st";
  } else if (lastOne === 2) {
    ending = "nd";
  } else if (lastOne === 3) {
    ending = "rd";
  } else {
    ending = "th";
  }

  return `${name}, you are the ${number}${ending} customer we serve today. Thank you!`;
}
