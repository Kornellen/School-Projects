export default function AdditionalInfo({
  feels,
  humidity,
  winds,
}: {
  feels: number;
  humidity: number;
  winds: number;
}) {
  return (
    <footer className="col-span-1 row-span-1 h-1/3">
      <div className="flex items-center m-5 p-4 h-40 rounded-xl backdrop-blur-md shadow-md shadow-[#ffffee28] bg-[#ffffee28]">
        <div className="w-1/3 h-1/2 text-center p-3">
          <h1>{feels}℃</h1>
          <p>Feels like</p>
        </div>
        <div className="w-1/3 h-1/2 text-center p-3">
          <h1>{humidity}%</h1>
          <p>Humidity</p>
        </div>
        <div className="w-1/3 h-1/2 text-center p-3">
          <h1>{winds} KPH</h1>
          <p>Winds</p>
        </div>
      </div>
    </footer>
  );
}
