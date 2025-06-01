using System;
using System.IO;
using System.Text;

public class Exercise25
{
    public static void Main()
    {
        // FileStream
        using (FileStream fs = new FileStream(""sample.txt"", FileMode.Create))
        {
            byte[] data = Encoding.UTF8.GetBytes(""Hello, FileStream!"");
            fs.Write(data, 0, data.Length);
        }

        using (FileStream fs = new FileStream(""sample.txt"", FileMode.Open))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            Console.WriteLine(Encoding.UTF8.GetString(buffer));
        }

        // MemoryStream
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes(""In-memory data!"");
            ms.Write(data, 0, data.Length);
            Console.WriteLine($""Bytes written: {ms.Length}"");
        }
    }
}
