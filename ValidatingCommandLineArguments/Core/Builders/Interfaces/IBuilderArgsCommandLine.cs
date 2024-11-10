using ValidatingCommandLineArguments.Core.ValidationArgs.Interfaces;

namespace ValidatingCommandLineArguments.Core.Builders.Interfaces;

public interface IBuilderArgsCommandLine
{
    public IBuilderArgsCommandLine AddArg(string nameArg, IValidationArg validationArg);
    public Dictionary<string, IValidationArg> Build();
}