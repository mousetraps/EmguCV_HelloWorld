﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Emgu.CV;
using Emgu.CV.CvEnum;
using CvEnum = Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;


namespace EmguCV_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //The name of the window
            String win1 = "Test Window";

            //Create the window using the specific name
            CvInvoke.cvNamedWindow(win1);

            //Create an image of 400x200 of Blue color
            using (Image<Bgr, Byte> img = new Image<Bgr, byte>(400, 200, new Bgr(255, 0, 0)))
            {
                //Create the font
                MCvFont f = new MCvFont(CvEnum.FONT.CV_FONT_HERSHEY_COMPLEX, 1.0, 1.0);
                //Draw "Hello, world." on the image using the specific font
                img.Draw("Hello, world", ref f, new Point(10, 80), new Bgr(0, 255, 0));

                //Show the image
                CvInvoke.cvShowImage(win1, img.Ptr);
                //Wait for the key pressing event
                CvInvoke.cvWaitKey(0);
                //Destory the window
                CvInvoke.cvDestroyWindow(win1);
            }
        }
    }
}
