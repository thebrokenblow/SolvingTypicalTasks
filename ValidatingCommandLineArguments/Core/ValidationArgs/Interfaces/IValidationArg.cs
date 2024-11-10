using ValidatingCommandLineArguments.Core.Model;

namespace ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

public interface IValidationArg
{
    ArgsStateDTO SetValidValue(string arg, ArgsStateDTO argsStateDto);
}