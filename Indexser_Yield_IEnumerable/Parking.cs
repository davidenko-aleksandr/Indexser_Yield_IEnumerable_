using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexser_Yield_IEnumerable
{
    public class Parking: IEnumerable
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this[string number] {
            get 
            {
                var car = _cars.First(c => c.Number == number);
                return car; 
            }
        }
        public Car this[int position]
        {
            get
            {
                if (position <= _cars.Count)
                {
                    return _cars[position];
                }
                else return null;
            }
            set
            {
                if (position<=_cars.Count)
                {
                    _cars[position] = value;
                }
            }
        }
        public int Count => _cars.Count;
        public string Name { get; set; }

        public int Add(Car car)
        {
            if (car==null)
            {
                throw new ArgumentNullException(nameof(car), "car is null");
            }
            if (_cars.Count<MAX_CARS)
            {
                _cars.Add(car);
            }
            else
            {
                return -1;
            }
            
            return _cars.Count - 1;
        }
        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "number is null or empty");
            }
            var car = _cars.First(c => c.Number==number);
            if (car!=null)
            {
                _cars.Remove(car);
            }
        }

     


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cars.GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var car in _cars)
            {
                yield return car;
            }
        }
        public IEnumerable GetName()
        {
            foreach (var car in _cars)
            {
                yield return car.Name;
            }
        }

    }
    public class ParkingEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
