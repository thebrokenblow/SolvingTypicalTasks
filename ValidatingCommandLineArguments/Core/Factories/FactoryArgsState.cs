using ValidatingCommandLineArguments.Core.Factories.Interfaces;
using ValidatingCommandLineArguments.Core.Model;

namespace ValidatingCommandLineArguments.Core.Factories;

public class FactoryArgsState : IFactoryArgsState
{
    public ArgsState Create(ArgsStateDTO argsStateDto) =>
        new()
        {
            District = argsStateDto.District ?? 
                       throw new NullReferenceException($"Property {nameof(argsStateDto.District)} is null"),
            
            FirstDeliveryDateTime = argsStateDto.FirstDeliveryDateTime ?? 
                                    throw new NullReferenceException($"Property {nameof(argsStateDto.FirstDeliveryDateTime)} is null"),
            
            FilePathOrder = argsStateDto.FilePathOrder ?? 
                            throw new NullReferenceException($"Property {nameof(argsStateDto.FilePathOrder)} is null"),
            
            FilePathLog= argsStateDto.FilePathLog ?? 
                         throw new NullReferenceException($"Property {nameof(argsStateDto.FilePathOrder)} is null"),
            
            FilePathFilterOrder = argsStateDto.District ?? 
                                  throw new NullReferenceException($"Property {nameof(argsStateDto.FilePathFilterOrder)} is null"),
        };
}