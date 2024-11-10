namespace ValidatingCommandLineArguments.Core.Model;

public class ArgsStateDTO
{
    public string? District { get; set; }
    public DateTime? FirstDeliveryDateTime { get; set; }
    public string? FilePathOrder { get; set; }
    public string? FilePathLog { get; set; }
    public string? FilePathFilterOrder { get; set; }
}