namespace RomanNumerals;
public static class Romans
{
    public static IDictionary<int, string> Translator = new Dictionary<int, string>
    {
        {1000, "M"},
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"},
    };
    public static string ToRomans(int number)
    {
        switch (number)
        {
            case <= 0:
                throw new ArgumentException("Value is lower than 0, it can't be represented in roman numbers");
            case >= 4000:
                throw new ArgumentException("Value has reach the limit of the roman numerals, this value cannot be represented.");
            default:
            {
                var result = _toRomans2(number);
                return result;
            }
        }
    }

    private static string _toRomans2(int number, int translatorIndex = 0)
    {
        foreach (var keyValue in Translator)
        {
            if (number < keyValue.Key)
            {
                translatorIndex++;
                continue;
            }
            // else
            return keyValue.Value + _toRomans2(number - keyValue.Key, translatorIndex);
        }

        return string.Empty;
    }

    /*
    /// <summary>
    /// first attempt, eeehhh, not so good though
    /// </summary>
    /// <param name="number"></param>
    /// <param name="dividerIndex"></param>
    /// <returns></returns>
    private static string _toRomans(int number, int dividerIndex = 0)
    {

        var reducer = 1000;
        if (number >= reducer)
        {
            return "M" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 900;
        if (number >= reducer)
        {
            return "CM" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 600;
        if (number >= reducer)
        {
            return "DC" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 500;
        if (number >= reducer)
        {
            return "D" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 400;
        if (number >= reducer)
        {
            return "CD" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 100;
        if (number >= reducer)
        {
            return "C" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 90;
        if (number >= reducer)
        {
            return "XC" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 60;
        if (number >= reducer)
        {
            return "LX" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 50;
        if (number >= reducer)
        {
            return "L" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 40;
        if (number >= reducer)
        {
            return "XL" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 10;
        if (number >= reducer)
        {
            return "X" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 9;
        if (number >= reducer)
        {
            return "IX" + _toRomans(number - reducer, dividerIndex);
        }

        reducer = 6;
        if (number >= reducer)
        {
            return "VI" + _toRomans(number - reducer, dividerIndex);
        }
        
        switch (number)
        {
            case 5: return "V";
            case 4: return "IV";
            case 3: return "III";
            case 2: return "II";
            case 1: return "I";
        }

        return "";
    }
    */
}
