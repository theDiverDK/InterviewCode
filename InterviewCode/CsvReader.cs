using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace InterviewCode;

public class CsvReader<T>
{
    private readonly string _filename;

    public CsvReader(string filename)
    {
        _filename = filename;
        if (!File.Exists(filename))
        {
            throw new FileNotFoundException($"The file '{filename}' does not exist.");
        }
    }

    public List<T> ReadCsv()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture);

        using var reader = new StreamReader(_filename, Encoding.UTF8);
        using var csv = new CsvReader(reader, config);

        var records = new List<T>();

        while (csv.Read())
        {
            try
            {
                var record = csv.GetRecord<T>();
                if (record != null)
                {
                    records.Add(record);
                }
            }
            catch (CsvHelperException ex)
            {
               Console.WriteLine($"Ignoring one line not confirming to standard");
            }
        }

        return records;
    }
}