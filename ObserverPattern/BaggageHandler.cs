using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> _observers;
        private List<BaggageInfo> _flights;

        public BaggageHandler()
        {
            _observers = new List<IObserver<BaggageInfo>>();
            _flights = new List<BaggageInfo>();
        }

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in _flights)
                    observer.OnNext(item);
            }
            return new Unsubscriber<BaggageInfo>(_observers, observer);
        }
        // Called to indicate all baggage is now unloaded.
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, String.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !_flights.Contains(info))
            {
                _flights.Add(info);
                foreach (var observer in _observers)
                    observer.OnNext(info);
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in _flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in _observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    _flights.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in _observers)
                observer.OnCompleted();

            _observers.Clear();
        }
    }
}

