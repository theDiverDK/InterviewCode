using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode;

public static class Program
{
    public static void Main(string[] args)
    {
        var filename = "input.csv";

        var devices = LoadCsvData<Device.Device>(filename).ToList(); // .ToList to avoid 'Possible multiple enumeration'

        Console.WriteLine();
        Console.WriteLine("List devices as described in interview task:");
        var interviewFilteredDevices = devices
            .ApplySerialNumberExactly10DigitLongFilter()
            .ApplyDeviceNameAtLeast1LongFilter();
        DisplayDevices(interviewFilteredDevices);

        Console.WriteLine(Environment.NewLine + Environment.NewLine + "The following list, are to show how easy it has been to extend the filtering,");
        Console.WriteLine(Environment.NewLine + "Devices with Empty DeviceName:");
        DisplayDevices(devices.ApplyEmptyDeviceNameFilter());

        Console.WriteLine(Environment.NewLine + "Devices with Empty DeviceName and SerialNumber Starting with '9':");
        var exampleFilteredDevices = devices
            .ApplyEmptyDeviceNameFilter()
            .ApplySerialNumberStartsWith9Filter();
        DisplayDevices(exampleFilteredDevices);
    }

    private static void DisplayDevices<T>(IEnumerable<T> devices) where T : IDevice
    {
        foreach (var device in devices)
        {
            Console.WriteLine(device.ToString());
        }
    }

    private static IEnumerable<T> LoadCsvData<T>(string filename)
    {
        var csvLoader = new CsvReader<T>(filename);
        return csvLoader.ReadCsv();
    }
}