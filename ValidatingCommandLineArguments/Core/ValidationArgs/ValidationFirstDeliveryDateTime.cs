using System.Globalization;
using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.ValidationArgs;

public class ValidationFirstDeliveryDateTime(
    string formatDateTime = "yyyy-MM-dd HH:mm:ss", 
    string nameCultureInfo = "ru-RU") : IValidationArg
{
    public ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto)
    {
        if (DateTime.TryParseExact(
                                arg,
                                formatDateTime,
                                new CultureInfo(nameCultureInfo),
                                DateTimeStyles.None,
                                out var deliveryTime))
        {
            argsStateDto.FirstDeliveryDateTime = deliveryTime;
        }
        else
        {
            throw new ArgumentException($"The Incorrect value for the date of the date and time first delivery: {arg}");
        }

        return argsStateDto;
    }
}