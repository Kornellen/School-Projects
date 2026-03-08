import { useState } from "react";
import "./App.css";
import Keyboard from "./components/Keyboard";
import Memory from "./components/Memory";

function performCalculation(
  val1: number,
  val2: number,
  operator: string,
): number | undefined {
  switch (operator) {
    case "+":
      return val1 + val2;
    case "-":
      return val1 - val2;
    case "*":
      return val1 * val2;
    case "/":
      return val1 / val2;
    case "%":
      return val1 % val2;
  }
}

const MEMO_BUFF: number = 20;

function historyInsert(prev: string[], items: string[]): string[] {
  if (prev.length === MEMO_BUFF) prev.pop();

  return (prev = [
    `${items[0]} ${items[1]} ${items[2]} = ${items[3]}`,
    ...prev,
  ]);
}

function App() {
  const [calculation, setCalculation] = useState<string>("0");
  const [memory, setMemory] = useState<string[]>([]);
  const [isResult, setIsResult] = useState<boolean>(false);

  function handleClick(e: React.MouseEvent<HTMLButtonElement>): void {
    const textContent = e.currentTarget.textContent;
    const isOperator = textContent.match(/[+\-*/%]/);
    setIsResult(false);

    if (calculation === "0" && isOperator && textContent !== "-") return;

    if (
      (calculation === "0" && textContent === "-") ||
      (calculation === "0" && textContent !== ".") ||
      (isResult && !isOperator)
    )
      return setCalculation(textContent);

    if (calculation.match(/[+\-*/%]/) && isOperator) return;

    setCalculation((prev) => prev + textContent);
  }

  const handleCalculate = () => {
    setIsResult(true);
    const match = calculation
      .match(/^(-?\d+(\.\d+)?)([+\-*/%])(\d+(\.\d+)?)$/)
      ?.filter(
        (val) =>
          val !== undefined && val !== calculation && !val.startsWith("."),
      );

    if (!match) return;

    const [val1, operator, val2] = match;

    const result = performCalculation(Number(val1), Number(val2), operator);

    if (!result) setCalculation("0");

    setMemory((prev) =>
      historyInsert(prev, [
        val1,
        operator,
        val2,
        String(result === undefined ? NaN : result),
      ]),
    );
    setCalculation(String(result));
  };

  const handleClear = () => {
    setCalculation("0");
    setIsResult(false);
  };

  const handleDelete = () => setCalculation((prev) => prev.slice(0, -1) || "0");

  return (
    <div className="h-screen bg-indigo-500 p-2">
      <div className="flex flex-1 flex-wrap bg-gray-800 m-2 p-3 w-250 rounded-md border-2 border-gray-500 border-dashed">
        <div className="display w-full h-14 bg-gray-900 text-4xl m-2 text-white p-2 rounded-sm text-right overflow-x-auto overflow-y-hidden">
          {calculation}
        </div>
        <div className="flex flex-1 h-100">
          <Keyboard
            handleCalculate={handleCalculate}
            handleClear={handleClear}
            handleClick={handleClick}
            handleDelete={handleDelete}
          />
          <Memory memory={memory} />
        </div>
      </div>
    </div>
  );
}

export default App;
