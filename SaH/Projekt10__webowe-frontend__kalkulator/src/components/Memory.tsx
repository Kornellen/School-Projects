export default function Memory({ memory }: { memory: string[] }) {
  return (
    <div className="w-1/2 h-full text-white rounded-sm  m-2 p-2 bg-gray-700">
      <p className="text-center text-3xl select-none">Memory:</p>
      <ul className="h-80 overflow-y-auto">
        {memory.map((memo, idx) => (
          <li
            className="text-2xl overflow-x-auto w-full border-b p-2 m-2 rounded-tl-sm rounded-tr-sm hover:bg-gray-800"
            key={`${memo}-${idx}`}
          >
            {memo}
          </li>
        ))}
      </ul>
    </div>
  );
}
