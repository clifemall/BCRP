using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions.Captcha
{
    public class clGetCaptcha
    {
        public clCaptchaResult GetImage()
        {
            Bitmap objBitmap = new Bitmap(130, 80);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
            objGraphics.Clear(Color.White);
            Random objRandom = new Random();
            objGraphics.DrawLine(Pens.Black, objRandom.Next(0, 50), objRandom.Next(10, 30), objRandom.Next(0, 200), objRandom.Next(0, 50));
            objGraphics.DrawRectangle(Pens.Blue, objRandom.Next(0, 20), objRandom.Next(0, 20), objRandom.Next(50, 80), objRandom.Next(0, 20));
            objGraphics.DrawLine(Pens.Blue, objRandom.Next(0, 20), objRandom.Next(10, 50), objRandom.Next(100, 200), objRandom.Next(0, 80));
            Brush objBrush =
                default(Brush);
            //create background style  
            HatchStyle[] aHatchStyles = new HatchStyle[]
            {
                HatchStyle.BackwardDiagonal, HatchStyle.Cross, HatchStyle.DashedDownwardDiagonal, HatchStyle.DashedHorizontal, HatchStyle.DashedUpwardDiagonal, HatchStyle.DashedVertical,
                    HatchStyle.DiagonalBrick, HatchStyle.DiagonalCross, HatchStyle.Divot, HatchStyle.DottedDiamond, HatchStyle.DottedGrid, HatchStyle.ForwardDiagonal, HatchStyle.Horizontal,
                    HatchStyle.HorizontalBrick, HatchStyle.LargeCheckerBoard, HatchStyle.LargeConfetti, HatchStyle.LargeGrid, HatchStyle.LightDownwardDiagonal, HatchStyle.LightHorizontal
            };
            //create rectangular area  
            RectangleF oRectangleF = new RectangleF(0, 0, 300, 300);
            objBrush = new HatchBrush(aHatchStyles[objRandom.Next(aHatchStyles.Length - 3)], Color.FromArgb((objRandom.Next(100, 255)), (objRandom.Next(100, 255)), (objRandom.Next(100, 255))), Color.White);
            objGraphics.FillRectangle(objBrush, oRectangleF);
            //Generate the image for captcha  
            string captchaText = string.Format("{0:X}", objRandom.Next(1000000, 9999999));

            //Set Result 
            clCaptchaResult entiResult = new clCaptchaResult();
            entiResult.stringCaptcha = captchaText.ToLower();
            
            //add the captcha value in session  
            //Session["CaptchaVerify"] = captchaText.ToLower();
            Font objFont = new Font("Courier New", 15, FontStyle.Bold);
            //Draw the image for captcha  
            objGraphics.DrawString(captchaText, objFont, Brushes.Black, 20, 20);
            //objGraphics.
            //entiResult.imageCaptcha = objBitmap.Save(Response.OutputStream, ImageFormat.Gif);
            using (MemoryStream ms = new MemoryStream())
            {
                objBitmap.Save(ms, ImageFormat.Gif);
                entiResult.image64Captcha = Convert.ToBase64String(ms.ToArray());
            }
         
            return entiResult;
        }
    }
}