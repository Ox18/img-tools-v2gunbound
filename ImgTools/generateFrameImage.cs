using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImgTools
{
    public class generateFrameImage
    {
        public void generate(string filena, bool iz, string abg, string ext, int marg, int rows)
        {

            Color bg = ColorTranslator.FromHtml(abg);
            if (iz)
            {
                bg = Color.Transparent;
            }
            string direct = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\gunboundImage\" + filena + @"\"+ext+@"\";
            string directly = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\gunboundImage\" + filena + @"\";
            string x_ = "";
            if (iz)
            {
                x_ = "_trans";
            }
            string directFinally = directly + filena + x_ + "."+ext;
            List<string> files = new List<string>();
            foreach (string filename in
                Directory.GetFiles(direct))
            {
                int pos = filename.LastIndexOf('.');
                string extension = filename.Substring(pos).ToLower();
                if (extension == "."+ext)
                {
                    
            
                    files.Add(filename);
                }
                    
            }

            int num_images = files.Count;
           
            if (num_images == 0)
            {
               
                MessageBox.Show("Selected 0 files");
                return;
            }

            // Load the images.
            Bitmap[] images = new Bitmap[files.Count];
            for (int i = 0; i < num_images; i++)
                images[i] = new Bitmap(files[i]);

            // Find the largest width and height.
            int max_wid = 0;
            int max_hgt = 0;
            for (int i = 0; i < num_images; i++)
            {
                if (max_wid < images[i].Width) max_wid = images[i].Width;
                if (max_hgt < images[i].Height) max_hgt = images[i].Height;
            }

            // Make the result bitmap.
            int margin = marg;
            int num_cols = num_images;
            if(rows != 0)
            {
                num_cols = rows;
            }

            int num_rows = (int)Math.Ceiling(num_images / (float)num_cols);
            int wid = max_wid * num_cols + margin * (num_cols - 1);
            int hgt = max_hgt * num_rows + margin * (num_rows - 1);
            
            Bitmap bm = new Bitmap(wid, hgt);

            // Place the images on it.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(bg);

                int x = 0;
                int y = 0;
                for (int i = 0; i < num_images; i++)
                {
                    gr.DrawImage(images[i], x, y);
                    x += max_wid + margin;
                    if (x >= wid)
                    {
                        y += max_hgt + margin;
                        x = 0;
                    }
                }
            }
            string dire = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\gunboundImage\" + filena + @"\";
            try {
            string code = "[["+(max_wid-1)+","+max_hgt+",0,0],"+num_images+"]";
            TextWriter tw = new StreamWriter(dire + "frame.min.txt");
            tw.WriteLine("Cantidad de Frames: " + num_images);
            tw.WriteLine("");
            tw.WriteLine(code);
            tw.Close();
            TextWriter tw2 = new StreamWriter(dire + "frame.txt");
                tw2.WriteLine("Cantidad de Frames: " + num_images);
                tw2.WriteLine("");
                string code2 = "";
                code2 += "[";
                for(int i = 0; i < num_images; i++)
                {
                    code2 += "[" + (max_wid - 1) + "," + max_hgt + ",0,0]";
                    if(i == num_images - 1)
                    {
                        code2 += "]";
                    }
                    else
                    {
                        code2 += ",";
                    }
                }
                tw2.WriteLine(code2);
                tw2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("un pequeño error de img");
            }
            
            dependSave dependsave = new dependSave();
            dependsave.saveMatchFile(bm, directFinally);

            if(ext == "bmp")
            {
                Bitmap myPic = new Bitmap(Image.FromFile(directFinally));
                myPic.MakeTransparent(bg);
             

                for(int i = 119; i < 188; i++)
                {
                    int z = i;
                    myPic.MakeTransparent(Color.FromArgb(z, z, z));
                }
                myPic.Save(dire+@"\refix.png", ImageFormat.Png);
            }
            

        } 
    }
}
