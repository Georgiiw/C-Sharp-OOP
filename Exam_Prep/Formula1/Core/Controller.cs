using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Repositories.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private IRepository<IPilot> pilotRepository;
        private IRepository<IRace> raceRepository;
        private IRepository<IFormulaOneCar> carRepository;
        public Controller()
        {
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = this.pilotRepository.FindByName(pilotName);
            var car = this.carRepository.FindByName(carModel);
            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages
                    .PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }
            if (car == null)
            {
                throw new NullReferenceException(String.Format(ExceptionMessages
                    .CarDoesNotExistErrorMessage, carModel));
            }
            pilot.AddCar(car);
            carRepository.Remove(car);
            return String.Format(OutputMessages.SuccessfullyPilotToCar, pilotName, car.GetType().Name, carModel);
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var race = this.raceRepository.FindByName(raceName);
            var pilot = this.pilotRepository.FindByName(pilotFullName);
            if (race == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages
                    .RaceDoesNotExistErrorMessage, raceName));
            }
            if (pilot == null || pilot.CanRace == false || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages
                    .PilotDoesNotExistErrorMessage, pilotFullName));
            }
            race.AddPilot(pilot);
            return string.Format(OutputMessages.SuccessfullyAddPilotToRace, pilotFullName, raceName);
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (this.carRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarExistErrorMessage, model));
            }
            if (type == "Ferrari")
            {
                IFormulaOneCar car = new Ferrari(model, horsepower, engineDisplacement);
                this.carRepository.Add(car);
            }
            else if (type == "Williams")
            {
                IFormulaOneCar car = new Williams(model, horsepower, engineDisplacement);
                this.carRepository.Add(car);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidTypeCar, type));
            }
            return String.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }

        public string CreatePilot(string fullName)
        {
            if (this.pilotRepository.FindByName(fullName) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }
            else
            {
                IPilot pilot = new Pilot(fullName);
                this.pilotRepository.Add(pilot);
            }
            return String.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race = new Race(raceName, numberOfLaps);
            if (this.raceRepository.FindByName(raceName) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }
            this.raceRepository.Add(race);
            return String.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();
            foreach (var pilot in this.pilotRepository.Models.OrderByDescending(x => x.NumberOfWins))
            {
                //sb.AppendLine($"Pilot {pilot.FullName} has {pilot.NumberOfWins} wins.");
                sb.AppendLine(pilot.ToString());
            }
            return sb.ToString().Trim();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();

            foreach (var race in this.raceRepository.Models.Where(x => x.TookPlace == true))
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().Trim();
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository.FindByName(raceName);
            if (race == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages
                    .RaceDoesNotExistErrorMessage, raceName));
            }
            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages
                    .InvalidRaceParticipants, raceName));
            }
            if (race.TookPlace)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages
                    .RaceTookPlaceErrorMessage, raceName));
            }
            List<IPilot> pilots = pilotRepository.Models
                .OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps))
                .ToList();
            race.TookPlace = true;
            pilots[0].WinRace();
            var sb = new StringBuilder();
            sb.AppendLine($"Pilot {pilots[0].FullName} wins the {raceName} race.");
            sb.AppendLine($"Pilot {pilots[1].FullName} is second in the {raceName} race.");
            sb.AppendLine($"Pilot {pilots[2].FullName} is third in the {raceName} race.");
            return sb.ToString().Trim();
            
        }
    }
}
