using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class prog{
    static void Main(string[] args)
    {
        using (FileStream fileStream = new FileStream("TEMPFILE.txt", FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write("Hello World!");
            }
        }
        using (FileStream fileStream = new FileStream("TEMPFILE.bin", FileMode.Create))
        {
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                writer.Write(10);
                writer.Write(20.5); writer.Write("Hello World!");
            }
        }
    }
}
