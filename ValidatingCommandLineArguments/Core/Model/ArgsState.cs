namespace ValidatingCommandLineArguments.Core.Model;

public class ArgsState
{
    public required string District { get; set; }
    public required DateTime? FirstDeliveryDateTime { get; set; }
    public required string FilePathOrder { get; set; }
    public required string FilePathLog { get; set; }
    public required string FilePathFilterOrder { get; set; }
}