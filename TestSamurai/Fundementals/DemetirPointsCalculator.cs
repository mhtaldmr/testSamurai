﻿namespace TestSamurai.Fundementals
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;
        private const int MaxSpeed = 300;

        public int CalculateDemeritPoints(int speed)
        {
            if (speed is < 0 or > MaxSpeed)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (speed <= SpeedLimit)
            {
                return 0;
            }

            const int kmPerDemeritPoint = 5;
            int demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}