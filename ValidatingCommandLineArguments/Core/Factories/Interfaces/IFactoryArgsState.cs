using ValidatingCommandLineArguments.Core.Model;

namespace ValidatingCommandLineArguments.Core.Factories.Interfaces;

public interface IFactoryArgsState
{
    ArgsState Create(ArgsStateDTO argsStateDto);
}