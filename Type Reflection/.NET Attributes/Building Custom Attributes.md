Building Custom Attributes

using System;
// A custom attribute.
public sealed class VehicleDescriptionAttribute :Attribute
{
public string Description { get; set; }


or security reasons, it is considered a .NET Core best practice to design all custom attributes as
sealed.

//Motorcycle.cs
namespace AttributedCarLibrary
{
// Assign description using a "named property."
[Serializable]
[VehicleDescription(Description = "My rocking Harley")]
public class Motorcycle
{


    