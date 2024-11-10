using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.ValidationArgs;

public class ValidationFilePathFilterOrder : IValidationArg
{
    public ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto)
    {
        arg = arg.Trim();

        if (!string.IsNullOrEmpty(arg))
        {
            argsStateDto.FilePathFilterOrder = arg;
        }
        else
        {
            throw new ArgumentException($"The Incorrect value for the path filtered orders: {arg}");
        }

        return argsStateDto;
    }
}