using System;

namespace ChallengeApp
{
    public class Statistics
    {
        public double High;
        public double Low;
        private double _sum;
        private int _count;

        public Statistics()
        {
            _count = 0;
            _sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public double Average => _sum / _count;

        public char Letter
        {
            get
            {
                return Average switch
                {
                    >= 90 => 'A',
                    >= 80 => 'B',
                    >= 70 => 'C',
                    >= 60 => 'D',
                    >= 50 => 'E',
                    _ => 'F'
                };
            }
        }

        public void Add(double number)
        {
            _sum += number;
            _count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }
    }
}