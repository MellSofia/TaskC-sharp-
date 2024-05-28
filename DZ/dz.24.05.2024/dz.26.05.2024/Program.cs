using System;
using System.IO;
namespace dz._26._05._2024
{
    internal class Program
    {
        static string path = "Structure";
        static string pathOriginal = "Structure";

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                dir.Delete(true);
                dir.Create();
            }
            else
            {
                dir.Create(); // создаем каталог
            }
            using (FileStream fileStream = new FileStream("Task.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string[] words = line.Split('\t');
                        foreach (string word in words)
                        {
                            if (word != words[words.Length - 1])
                            {
                                path = Path.Combine(path, word);
                                DirectoryInfo dir1 = new DirectoryInfo(path);
                                if (!dir1.Exists)
                                {
                                    dir1.Create();
                                }
                            }
                            else
                            {
                                File.Create(path + $@"\{word}.txt");
                            }
                        }
                        path = pathOriginal;
                    }
                }
            }
        }
    }
}
