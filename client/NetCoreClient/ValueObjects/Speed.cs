﻿namespace NetCoreClient.ValueObjects;

internal class Speed
{
    public int Value { get; set; }
    
    public Speed(int value)
    {
        this.Value = value;
    }
}
