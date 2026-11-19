import React from "react";

export default function Form({
  handleSubmit,
}: {
  handleSubmit: (e: React.SubmitEvent<HTMLFormElement>) => void;
}) {
  return (
    <form onSubmit={handleSubmit}>
      <div className="">
        <div className="">
          <label htmlFor="car" className="form-label fs-5">
            Samochód:
          </label>
          <select className="form-select fs-3 w-50" name="car" id="car">
            <option value={"skf"}>Skoda Fabia</option>
            <option value={"toy"}>Toyota Yaris</option>
            <option value={"opa"}>Opel Astra</option>
            <option value={"vop"}>Volkswagen Passat</option>
          </select>
        </div>
        <div className="d-flex">
          <div className="from-group">
            <label htmlFor="from" className="form-label fs-5">
              Od:
            </label>
            <br />
            <input
              className="from-control fs-3"
              type="date"
              name="from"
              id="from"
            />
          </div>
          <div className="form-group ms-5">
            <label htmlFor="to" className="form-label fs-5">
              Do:
            </label>
            <br />
            <input
              className="from-control fs-3"
              type="date"
              name="to"
              id="to"
            />
          </div>
        </div>
        <div className="form-group mt-2">
          <div className="form-field">
            <input type="checkbox" name="kid" id="kid" className="check" />
            <label htmlFor="kid" className="ms-2">
              Fotelik dziecięcy (10zł/doba)
            </label>
          </div>
          <div className="form-field">
            <input type="checkbox" name="gps" id="gps" className="check" />
            <label htmlFor="gps" className="ms-2">
              GPS (15zł/doba)
            </label>
          </div>
          <div className="form-field">
            <input
              type="checkbox"
              name="insurence"
              id="insurence"
              className="check"
            />
            <label htmlFor="insurence" className="ms-2">
              Ubezpieczenie (25zł/doba)
            </label>
          </div>
        </div>
        <button type="submit" className="btn w-25 btn-primary mt-2">
          Oblicz Koszt
        </button>
      </div>
    </form>
  );
}
