﻿using System;

namespace Geo.Geomagnetism.Models;

public class Wmm2010 : IGeomagneticModel
{
    public DateTime ValidFrom => new(2010, 1, 1);
    public DateTime ValidTo => new(2015, 1, 1);

    public double[,] MainCoefficientsG
    {
        get
        {
            return new[,]
            {
                { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -29496.6, -1586.3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -2396.6, 3026.1, 1668.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 1340.1, -2326.2, 1231.9, 634, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 912.6, 808.9, 166.7, -357.1, 89.4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -230.9, 357.2, 200.3, -141.1, -163, -7.8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 72.8, 68.6, 76, -141.4, -22.8, 13.2, -77.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 80.5, -75.1, -4.7, 45.3, 13.9, 10.4, 1.7, 4.9, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 24.4, 8.1, -14.5, -5.6, -19.3, 11.5, 10.9, -14.1, -3.7, 0.0, 0.0, 0.0, 0.0 },
                { 5.4, 9.4, 3.4, -5.2, 3.1, -12.4, -0.7, 8.4, -8.5, -10.1, 0.0, 0.0, 0.0 },
                { -2, -6.3, 0.9, -1.1, -0.2, 2.5, -0.3, 2.2, 3.1, -1, -2.8, 0.0, 0.0 },
                { 3, -1.5, -2.1, 1.7, -0.5, 0.5, -0.8, 0.4, 1.8, 0.1, 0.7, 3.8, 0.0 },
                { -2.2, -0.2, 0.3, 1, -0.6, 0.9, -0.1, 0.5, -0.4, -0.4, 0.2, -0.8, 0.0 }
            };
        }
    }

    public double[,] MainCoefficientsH
    {
        get
        {
            return new[,]
            {
                { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 4944.4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -2707.7, -576.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -160.2, 251.9, -536.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 286.4, -211.2, 164.3, -309.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 44.6, 188.9, -118.2, 0.0, 100.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -20.8, 44.1, 61.5, -66.3, 3.1, 55, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -57.9, -21.1, 6.5, 24.9, 7, -27.7, -3.3, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 11, -20, 11.9, -17.4, 16.7, 7, -10.8, 1.7, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -20.5, 11.5, 12.8, -7.2, -7.4, 8, 2.1, -6.1, 7, 0.0, 0.0, 0.0 },
                { 0.0, 2.8, -0.1, 4.7, 4.4, -7.2, -1, -3.9, -2, -2, -8.3, 0.0, 0.0 },
                { 0.0, 0.2, 1.7, -0.6, -1.8, 0.9, -0.4, -2.5, -1.3, -2.1, -1.9, -1.8, 0.0 },
                { 0.0, -0.9, 0.3, 2.1, -2.5, 0.5, 0.6, 0.0, 0.1, 0.3, -0.9, -0.2, 0.9 }
            };
        }
    }

    public double[,] SecularCoefficientsG
    {
        get
        {
            return new[,]
            {
                { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 11.6, 16.5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -12.1, -4.4, 1.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.4, -4.1, -2.9, -7.7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -1.8, 2.3, -8.7, 4.6, -2.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -1, 0.6, -1.8, -1, 0.9, 1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -0.2, -0.2, -0.1, 2, -1.7, -0.3, 1.7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.1, -0.1, -0.6, 1.3, 0.4, 0.3, -0.7, 0.6, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { -0.1, 0.1, -0.6, 0.2, -0.2, 0.3, 0.3, -0.6, 0.2, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -0.1, 0.0, 0.3, -0.4, -0.3, 0.1, -0.1, -0.4, -0.2, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, -0.1, 0.2, 0.0, -0.1, -0.2, 0.0, -0.1, -0.2, -0.2, 0.0, 0.0 },
                { 0.0, 0.0, 0.0, 0.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.1, 0.0, 0.0 },
                { 0.0, 0.0, 0.1, 0.1, -0.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.1, 0.1 }
            };
        }
    }

    public double[,] SecularCoefficientsH
    {
        get
        {
            return new[,]
            {
                { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -25.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -22.5, -11.8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 7.3, -3.9, -2.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 1.1, 2.7, 3.9, -0.8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.4, 1.8, 1.2, 4, -0.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -0.2, -2.1, -0.4, -0.6, 0.5, 0.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.7, 0.3, -0.1, -0.1, -0.8, -0.3, 0.3, 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, -0.1, 0.2, 0.4, 0.4, 0.1, -0.1, 0.4, 0.3, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, -0.2, 0.0, -0.1, 0.1, 0.0, -0.2, 0.3, 0.2, 0.0, 0.0, 0.0 },
                { 0.0, 0.1, -0.1, 0.0, -0.1, -0.1, 0.0, -0.1, -0.2, 0.0, -0.1, 0.0, 0.0 },
                { 0.0, 0.0, 0.1, 0.0, 0.1, 0.0, 0.1, 0.0, -0.1, -0.1, 0.0, -0.1, 0.0 },
                { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }
            };
        }
    }
}