export function decodedResistorValue(colors: string[]) {
  const first = COLORS.indexOf(colors[0])
  const second = COLORS.indexOf(colors[1])
  const multiplier = COLORS.indexOf(colors[2])

  const baseValue = first * 10 + second;
  const ohms = baseValue * 10 ** multiplier;

  const units = ['ohms', 'kiloohms', 'megaohms', 'gigaohms'];
  let value = ohms;
  let unitIndex = 0;

  while (value >= 1000 && value % 1000 === 0 && unitIndex < units.length - 1) {
    value /= 1000;
    unitIndex++;
  }
  return `${value} ${units[unitIndex]}`;
}

const COLORS: string[] = [
  'black',
  'brown',
  'red',
  'orange',
  'yellow',
  'green',
  'blue',
  'violet',
  'grey',
  'white'
]