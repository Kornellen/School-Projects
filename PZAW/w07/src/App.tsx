import { useEffect, useState } from "react";

const formatMillisToRedableFormat = (ms: number) => {
  const hour = Math.floor(ms / (60 * 60 * 1000));
  const minutes = Math.floor(ms / (60 * 1000)) % 60;
  const seconds = Math.floor(ms / 1000) % 60;
  const millis = ms % 1000;

  const formatTimeValue = (timeValue: number) => {
    if (timeValue < 10) return `0${timeValue}`;
    return `${timeValue}`;
  };

  const formatMillis = (millisValue: number) => {
    if (millisValue < 10) return `00${millisValue}`;
    if (millisValue < 100) return `0${millisValue}`;
    return `${millisValue}`;
  };

  return `${formatTimeValue(hour)}:${formatTimeValue(minutes)}:${formatTimeValue(seconds)}.${formatMillis(millis)}`;
};

type Lap = { lapTime: number; totalTime: number; idx: number };
type Statistics = { fastest: Lap; slowest: Lap; average: number };
export default function App() {
  const [isStopperStarted, setIsStopperStarted] = useState<boolean>(false);
  const [stopperTime, setStopperTime] = useState<number>(0); // holds elapsed time in millis
  const [startDate, setStartDate] = useState<number | null>(null);
  const [stats, setStats] = useState<Statistics>({
    fastest: { idx: 0, lapTime: 0, totalTime: 0 },
    slowest: { idx: 0, lapTime: 0, totalTime: 0 },
    average: 0,
  });
  const [laps, setLaps] = useState<Lap[]>([]);

  useEffect(() => {
    if (!isStopperStarted) return;

    if (startDate === null)
      (() => setStartDate(Number(new Date()) - stopperTime))();

    const interval = setInterval(() => {
      if (startDate !== null) {
        const tickDate = Number(new Date());
        setStopperTime(() => tickDate - startDate);
      }
    }, 10);

    return () => clearInterval(interval);

    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [isStopperStarted, startDate]);

  const handleStartClick = () => {
    if (!isStopperStarted) {
      setStartDate(Number(new Date()) - stopperTime);
      setIsStopperStarted(true);
    } else {
      setIsStopperStarted(false);
      setStartDate(null);
    }
  };

  const handleLapClick = () => {
    setLaps((prev) => [
      {
        lapTime: prev[prev.length - 1]
          ? stopperTime - prev[prev.length - 1].totalTime
          : stopperTime,
        totalTime: stopperTime,
        idx: prev.length + 1,
      },
      ...prev,
    ]);
  };

  useEffect(() => {
    if (laps.length === 0) {
      // eslint-disable-next-line react-hooks/set-state-in-effect
      setStats({
        fastest: { idx: 0, lapTime: 0, totalTime: 0 },
        slowest: { idx: 0, lapTime: 0, totalTime: 0 },
        average: 0,
      });
      return;
    }

    let fastest: Lap = laps[0];
    let slowest: Lap = laps[0];
    const average: number =
      laps.reduce((acc, lap) => acc + lap.lapTime, 0) / laps.length;

    laps.forEach((lap) => {
      if (lap.lapTime < fastest.lapTime) fastest = lap;
      if (lap.lapTime > slowest.lapTime) slowest = lap;
    });

    setStats({ fastest, slowest, average });
  }, [laps]);

  const handleResetClick = () => {
    setStopperTime(0);
    setStartDate(null);
    setIsStopperStarted(false);
    setLaps([]);
    setStats({
      fastest: { idx: 0, lapTime: 0, totalTime: 0 },
      slowest: { idx: 0, lapTime: 0, totalTime: 0 },
      average: 0,
    });
  };

  return (
    <main className="text-center mt-3">
      <h1>Stoper</h1>
      <p className="font-monospace display-3">
        {formatMillisToRedableFormat(stopperTime)}
      </p>
      <section>
        <button
          className={`btn ${isStopperStarted ? "btn-danger" : "btn-success"} m-2`}
          onClick={handleStartClick}
        >
          {isStopperStarted ? "STOP" : "START"}
        </button>
        <button
          className="btn btn-secondary m-2"
          disabled={!isStopperStarted}
          onClick={handleLapClick}
        >
          Okrążenie
        </button>
        <button
          className="btn btn-outline-dark m-2"
          disabled={stopperTime > 0 && isStopperStarted}
          onClick={handleResetClick}
        >
          Reset
        </button>
      </section>
      {stats.fastest.lapTime > 0 && stats.slowest.lapTime > 0 && (
        <section>
          <p>
            Najszybsze: #{stats.fastest.idx} (
            {formatMillisToRedableFormat(stats.fastest.lapTime)}) |
            Najwolniejsze: #{stats.slowest.idx} (
            {formatMillisToRedableFormat(stats.slowest.lapTime)}) | Średnie:{" "}
            {formatMillisToRedableFormat(stats.average)}
          </p>
        </section>
      )}
      {laps.length > 0 && (
        <section>
          <table className="table table-sm">
            <thead>
              <tr>
                <th>Nr</th>
                <th>Czas okrążenia</th>
                <th>Czas całkowity</th>
              </tr>
            </thead>
            <tbody>
              {laps.map((lap, idx) => (
                <tr
                  className={
                    lap.lapTime === stats.fastest.lapTime
                      ? "table-success"
                      : lap.lapTime === stats.slowest.lapTime
                        ? "table-danger"
                        : ""
                  }
                  key={`${lap.lapTime}-${idx}`}
                >
                  <td>{lap.idx}</td>
                  <td>{formatMillisToRedableFormat(lap.lapTime)}</td>
                  <td>{formatMillisToRedableFormat(lap.totalTime)}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </section>
      )}
    </main>
  );
}
