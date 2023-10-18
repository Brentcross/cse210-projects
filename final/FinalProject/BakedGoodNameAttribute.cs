using System;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
sealed class BakedGoodNameAttribute : Attribute
{
    public string Name { get; }

    public BakedGoodNameAttribute(string name)
    {
        Name = name;
    }
}
