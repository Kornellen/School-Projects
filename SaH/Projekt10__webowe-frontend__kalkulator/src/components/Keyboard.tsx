import Button from "./Button";

const BUTTONS = [
  "7",
  "8",
  "9",
  "*",

  "4",
  "5",
  "6",
  "-",

  "1",
  "2",
  "3",
  "+",

  "0",
  ".",
  "%",
];

type KeyboardType = {
  handleClear: () => void;
  handleClick: (e: React.MouseEvent<HTMLButtonElement>) => void;
  handleCalculate: () => void;
  handleDelete: () => void;
};

export default function Keyboard({
  handleClear,
  handleClick,
  handleCalculate,
  handleDelete,
}: KeyboardType) {
  return (
    <div className="grid grid-cols-4 grid-rows-5 gap-2 m-2 w-full">
      <Button
        content="AC"
        onClick={handleClear}
        className="col-span-2 bg-gray-700 text-3xl text-white p-2 text-center hover:bg-gray-600 rounded-sm select-none"
      />
      <Button content="DEL" onClick={handleDelete} />
      <Button content="/" onClick={handleClick} />
      {BUTTONS.map((button) => (
        <Button key={button} onClick={handleClick} content={button} />
      ))}
      <Button
        className="col-span-1 row-span-1 bg-gray-900 text-3xl text-center text-white rounded-sm select-none hover:bg-gray-500"
        content="="
        onClick={handleCalculate}
      />
    </div>
  );
}
