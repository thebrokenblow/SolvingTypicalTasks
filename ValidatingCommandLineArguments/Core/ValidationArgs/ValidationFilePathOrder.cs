using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.ValidationArgs;

public class ValidationFilePathOrder : IValidationArg
{
    public ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto)
    {
        arg = arg.Trim();

        if (!string.IsNullOrEmpty(arg))
        {
            argsStateDto.FilePathOrder = arg;
        }
        else
        {
            throw new ArgumentException($"The Incorrect value for the orders path: {arg}");
        }

        return argsStateDto;
    }
}