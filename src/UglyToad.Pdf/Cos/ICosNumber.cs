﻿namespace UglyToad.Pdf.Cos
{
    internal interface ICosNumber
    {
        float AsFloat();

        double AsDouble();

        int AsInt();

        long AsLong();

        decimal AsDecimal();
    }
}
