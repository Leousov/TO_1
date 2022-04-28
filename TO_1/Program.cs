using System;
using System.Drawing;

namespace TO_1
{
    public class Program
    {
        public static void Main()
        {
            string inputfolder = @"C:\Users\Baphometh\source\repos\TO_1\TestProject2\TestData\Input";
            int imgCount = 3;
            Console.WriteLine("HW!");
            var images = IoWorker.Load(inputfolder);
            for (int i = 0; i < imgCount; i++)
            {
                Console.WriteLine(images[i].Size.ToString());
                //Assert.AreEqual((int)i, images[i].Size);
            }
        }
    }
    public static class IoWorker
    {
        public static List<Bitmap> Load(string folder)
        {
            var fileNames = Directory.GetFiles(folder);
            var images = new List<Bitmap>();
            foreach(var file in fileNames)
            {
                if (file.EndsWith(".bmp") || file.EndsWith(".jpg") || file.EndsWith(".png"))
                {
                    try
                    {
                        images.Add(new Bitmap(file));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            return images;
        }
    }
    public static class Magic
    {
        public static Bitmap Resize(Bitmap b, int wout, int hout)
        {
            return b;
        }
    }
}