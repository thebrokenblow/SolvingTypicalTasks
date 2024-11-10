using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.ValidationArgs;

public class ValidationCityDistrict : IValidationArg
{
    public ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto)
    {
        arg = arg.Trim();

        if (argsStateDto.District is not null)
        {
            throw new ArgumentException($"The Incorrect value for district: {arg}");
        }

        if (!string.IsNullOrEmpty(arg))
        {
            argsStateDto.District = arg;
        }
        else
        {
            throw new ArgumentException($"The Incorrect value for district: {arg}");
        }

        return argsStateDto;
    }
}