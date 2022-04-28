using NUnit.Framework;
using System;
using System.Drawing;
using TO_1;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(@"C:\Users\Baphometh\source\repos\TO_1\TestProject2\TestData\Input", 3)]
        public void LoadAllImagesFromInputFolder(string inputfolder, int imgCount)
        {
            var images = IoWorker.Load(inputfolder);
            Assert.NotNull(images);
            Assert.AreEqual(imgCount, images.Count);
        }
        [TestCase(100, 200, 50, 150)]
        public void Checksize(int widthin, int heightin, int widthout, int heightout)
        {
            Bitmap imin = new Bitmap(widthin, heightin);
            Bitmap iout = Magic.Resize(imin, widthout, heightout);
            Assert.NotNull(iout);
            Assert.AreEqual(widthout, iout.Width);
            Assert.AreEqual(heightout, iout.Height);

        }
    }
}