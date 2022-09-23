using System.Linq;
using UnityEngine;
using System;
using static UnityEngine.Color;

public static class Extension_String
{
    public const string redHex = "#FF0000";
    public const string greenHex = "#00FF00";
    public const string blueHex = "#0000FF";
    public const string yellowHex = "#FFFF00";
    public const string cyanHex = "#00FFFF";
    public const string magentaHex = "#FF00FF";
    public const string whiteHex = "#FFFFFF";
    public const string blackHex = "#000000";
    public const string grayHex = "#808080";
    public const string greyHex = "#808080";
    public const string clearHex = "#00000000";
    public const string orangeHex = "#FFA500";
    public const string purpleHex = "#800080";
    public const string brownHex = "#A52A2A";


    /// <summary>
    /// Adds the color tag to the string, using the rich text TMPro format.
    /// </summary>
    /// <param name="str">Implicit reference to the string</param>
    /// <param name="color">The color you want the string to be. All constants in UnityEngine.Color are implemented.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">The method will throw an exception if the argument is invalid.</exception>
    public static string Colorize(this string str, Color color)
    {
        if (color == white || color == clear || color == black)
            Debug.LogError(
                $"The {nameof(Colorize)} method was called with a value of {color} for the {nameof(color)} argument." +
                $" This is probably a mistake, likely by passing no value to the Color() constructor." +
                $" If this is deliberate, please use the appropriate Color constant in UnityEngine.Color for code readability.");
        return "<color=#" + ColorUtility.ToHtmlStringRGBA(color) + ">" + str + "</color>";
    }

    public static string Colorize(this string str, string hexadecimalColor)
    {
        return $"<color={hexadecimalColor}>{str}</color>";
    }
}