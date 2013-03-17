using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processImages(String[] filenames, String relative_final_name)
        {
            int w = 0;
            int h = 0;
            int count = 0;
            string dir = "";

            foreach (String fn in filenames)
            {
                //richTextBox1.Text = richTextBox1.Text + "\n" + fn;
                Image t = Image.FromFile(fn);
                //richTextBox1.Text = richTextBox1.Text + "\n" + a.Width + " x " + a.Height + "\n";
                w = t.Width;
                h = t.Height;
                dir = System.IO.Path.GetDirectoryName(fn);
                count++;
                t.Dispose();
            }
            richTextBox1.AppendText("Count: " + count + "\n");
            richTextBox1.AppendText("Size: " + w + "x" + h + "\n");
            richTextBox1.AppendText("Dir: " + dir + "\n");

            //fixed int[8] mask;
            Random rand = new Random();
            int[,] mask = new int[w, h];
            richTextBox1.AppendText("Mask: " + w + "x" + h + "\n");


            if (radioButton4.Checked)
            {
                // Blocks

                int block_width = int.Parse(textBox1.Text);
                int block_height = int.Parse(textBox2.Text);
                int block_count_x = w / block_width;
                int block_count_y = h / block_height;

                if (block_count_x < 1)
                {
                    block_count_x = 1;
                }
                if (block_count_y < 1)
                {
                    block_count_y = 1;
                }

                richTextBox1.AppendText("Blocks: " + block_count_x + " x " + block_count_y + "\n");

                int[,] blockmask = new int[block_count_x, block_count_y];
                for (int y = 0; y < block_count_y; y++)
                {

                    for (int x = 0; x < block_count_x; x++)
                    {
                        //mask[x, y] = ;
                        int rnd = rand.Next(0, count);
                        blockmask[x, y] = rnd;
                        //richTextBox1.AppendText("BM: " + x + " - " + y + " = " + rnd + "\n");
                    }
                    //break;
                }

                //richTextBox1.Text = "";
                /*
                //int blocksize = w / 816; // 4x4
                //int blocksize = w / (816 / 4); // 4x4
                int blocksize = w / 51;

                
                int[,] blockmask = new int[w / blocksize, h / blocksize];
                for (int y = 0; y < h / blocksize; y++)
                {

                    for (int x = 0; x < w / blocksize; x++)
                    {
                        //mask[x, y] = ;
                        int rnd = rand.Next(0, count);
                        blockmask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }*/

                int mx = 0;
                int my = 0;
                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        //mask[x, y] = ;
                        //int rnd = rand.Next(0, count);
                        /*int px = x / blocksize;
                        int py = y / blocksize;

                        if (px > w / blocksize)
                        {
                            px = (w / blocksize)-2;
                        }

                        if (py > h / blocksize)
                        {
                            py = (h / blocksize)-2;
                        }

                        px = 1;
                        py = 1;*/

                        int px = x / block_width;
                        int py = y / block_height;

                        if (px >= block_count_x)
                        {
                            px = block_count_x - 1;
                        }
                        if (px < 0)
                        {
                            px = 0;
                        }

                        if (py >= block_count_y)
                        {
                            py = block_count_y - 1;
                        }
                        if (py < 0)
                        {
                            py = 0;
                        }

                        /*px--;
                        py--;
                        if (px < 0) { px = 0; }
                        if (py < 0) { py = 0; }
                        px = 1 -1;
                        py = 1 -1;

                        if (px > mx) { mx = px; }
                        if (py > my) { my = py; }*/

                        //richTextBox1.AppendText("Get blocks: " + px + " x " + py + "\n");
                        //richTextBox1.Text = "Get blocks: " + px + " x " + py + "\n";

                        //px = 0; py = 0;
                        int rnd = 0;
                        try
                        {
                            //  int rnd = blockmask[px, py];
                            //richTextBox1.AppendText("Try Get blocks: " + px + " x " + py + "\n");
                            rnd = blockmask[px, py];
                            // richTextBox1.AppendText("OK\n");
                        }
                        catch (System.IndexOutOfRangeException ex)
                        {
                            //richTextBox1.AppendText(ex.Message);
                            richTextBox1.AppendText(px + " x " + py + " - " + ex.Message + "\n");
                        }
                        finally
                        {
                            //mask[x, y] = 1;
                        }
                        mask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }
                richTextBox1.AppendText("Get blocks: " + mx + " x " + my + "\n");
            }

            if (radioButton3.Checked)
            {
                // Lines horizontal
                for (int y = 0; y < h; y++)
                {
                    int rnd = rand.Next(0, count);
                    for (int x = 0; x < w; x++)
                    {
                        //mask[x, y] = ;
                        mask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }
            }

            if (radioButton2.Checked)
            {
                // Lines vertical
                for (int x = 0; x < w; x++)
                {
                    int rnd = rand.Next(0, count);
                    for (int y = 0; y < h; y++)
                    {
                        //mask[x, y] = ;
                        mask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }
            }

            if (radioButton1.Checked)
            {
                // Pixel
                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        //mask[x, y] = ;
                        int rnd = rand.Next(0, count);
                        mask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }
            }


            //int[,] multiDimensionalArray1 = new int[w, h];
            //Image final = Image
            Bitmap fin = new Bitmap(w, h);


            int n = 0;
            progressBar1.Maximum = w * h;
            progressBar1.Value = 0;
            foreach (String fn in filenames)
            {
                Bitmap t = new Bitmap(fn);


                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {

                        if (mask[x, y] == n)
                        {
                            fin.SetPixel(x, y, t.GetPixel(x, y));
                            progressBar1.Value = progressBar1.Value + 1;
                            Application.DoEvents();
                        }
                        //mask[x, y] = ;
                        //int rnd = rand.Next(0, count);
                        //mask[x, y] = rnd;
                        //richTextBox1.AppendText("Mask: " + x + "x" + y + " = " + rnd + "\n");
                    }
                    //break;
                }


                //richTextBox1.Text = richTextBox1.Text + "\n" + fn;
                // Image t = Image.FromFile(fn);
                //richTextBox1.Text = richTextBox1.Text + "\n" + a.Width + " x " + a.Height + "\n";
                //w = t.Width;
                //h = t.Height;
                //dir = System.IO.Path.GetDirectoryName(fn);
                //count++;
                //t.Dispose();
                t.Dispose();
                n++;
            }



            //fin.SetPixel

            //richTextBox1.Text = openFileDialog1.FileNames.ToString();

            richTextBox1.AppendText("Save to: " + dir + "/" + relative_final_name + ".png" + "\n");
            ///final.bmp

            fin.Save(dir + "/" + relative_final_name + ".png", ImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                processImages(openFileDialog1.FileNames, "final");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = folderBrowserDialog1.SelectedPath;
                richTextBox1.AppendText(folderBrowserDialog1.SelectedPath + "\n");
                DirectoryInfo dirinfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] files = dirinfo.GetFiles();
                //FileInfo[] files = dirinfo.EnumerateFiles().OrderByDescending(x => x.Name);

                var filtered = files.Select(f => f)
                    .Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

                //foreach (var f in files)
                foreach (var f in filtered)
                {
                    richTextBox1.AppendText(f.FullName + "\n");
                    //Debug.WriteLine(f);
                }

            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
