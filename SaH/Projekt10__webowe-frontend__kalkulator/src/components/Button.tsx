export default function Button({
  content,
  onClick,
  className,
}: {
  content: string;
  onClick: (e: React.MouseEvent<HTMLButtonElement>) => void;
  className?: string;
}) {
  return (
    <button
      className={
        className ||
        "col-span-1 bg-gray-700 text-3xl text-white p-2 text-center hover:bg-gray-600 rounded-sm select-none"
      }
      onClick={onClick}
    >
      {content}
    </button>
  );
}
