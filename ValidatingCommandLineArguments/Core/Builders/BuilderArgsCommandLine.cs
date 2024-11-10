using ValidatingCommandLineArguments.Core.Builders.Interfaces;
using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.Builders;

public class BuilderArgsCommandLine : IBuilderArgsCommandLine
{
    private readonly Dictionary<string, IValidationArg> _argsValidation = [];

    public IBuilderArgsCommandLine AddArg(string nameArg, IValidationArg validationArg)
    {
        if (!_argsValidation.TryAdd(nameArg, validationArg))
        {
            throw new Exception();    
        }

        return this;
    }

    public Dictionary<string, IValidationArg> Build() => 
        _argsValidation;
}