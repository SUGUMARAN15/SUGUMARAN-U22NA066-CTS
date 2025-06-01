using System;
using System.Threading.Tasks;

public class Exercise23
{
    public static async Task<string> UploadFileAsync()
    {
        await Task.Delay(3000); // Simulate upload
        return ""Upload successful!"";
    }

    public static async Task Main()
    {
        try
        {
            string result = await UploadFileAsync();
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($""Error: {ex.Message}"");
        }
    }
}
