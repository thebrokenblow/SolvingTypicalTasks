using ValidatingCommandLineArguments.Core.Builders;
using ValidatingCommandLineArguments.Core.CommandLine;
using ValidatingCommandLineArguments.Core.Factories;
using ValidatingCommandLineArguments.Core.Model;
using ValidatingCommandLineArguments.Core.ValidationArgs;

var argsValidation = new BuilderArgsCommandLine()
    .AddArg("_cityDistrict", new ValidationCityDistrict())
    .AddArg("_firstDeliveryDateTime", new ValidationFirstDeliveryDateTime())
    .AddArg("_sourceOrder", new ValidationFilePathOrder())
    .AddArg("_deliveryLog", new ValidationFilePathLog())
    .AddArg("_deliveryOrder", new ValidationFilePathFilterOrder())
    .Build();

var argsStateDto = new ArgsCommandLine(argsValidation).Validate(args);

var factoryArgsState = new FactoryArgsState();
var argsState = factoryArgsState.Create(argsStateDto);

//Теперь можно использовать аргументы командной строки

