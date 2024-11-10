using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.ValidationArgs;

public class ValidationFilePathLog : IValidationArg
{
    public ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto)
    {
        arg = arg.Trim();

        if (!string.IsNullOrEmpty(arg))
        {
            argsStateDto.FilePathLog = arg;
        }
        else
        {
            throw new ArgumentException($"The Incorrect value for the path logs: {arg}");
        }

        return argsStateDto;
    }
}