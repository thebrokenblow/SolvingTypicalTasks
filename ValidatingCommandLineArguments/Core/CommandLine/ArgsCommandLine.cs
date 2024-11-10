using ValidatingCommandLineArguments.Core.Extensions;
using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.CommandLine;

public class ArgsCommandLine(Dictionary<string, IValidationArg> argsValidation)
{
    private const int CountElementsArgument = 2;
    private const char AssignmentOperator = '=';

    public ArgsStateDTO Validate(string[] args)
    {
        if (args.Length != argsValidation.Count)
        {
            throw new ArgumentException("Incorrect number of arguments");
        }

        var argsStateDto = new ArgsStateDTO();

        foreach (var arg in args)
        {
            var currentArgs = arg.Split(AssignmentOperator, CountElementsArgument);
            var nameParameter = currentArgs.First();

            if (argsValidation.TryGetValue(nameParameter, out var validationArg))
            {
                validationArg.SetValidValue(currentArgs.Second(), argsStateDto);
            }
            else
            {
                throw new ArgumentException($"Incorrect argument name has been entered: {nameParameter}");
            }
        }

        return argsStateDto;
    }
}