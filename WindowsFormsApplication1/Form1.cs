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
    public partial class frmMain : Form
    {
        public frmMain()
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
                Image t = Image.FromFile(fn);
                w = t.Width;
                h = t.Height;
                dir = System.IO.Path.GetDirectoryName(fn);
                count++;
                t.Dispose();
            }
            txtStatus.AppendText("Count: " + count + "\n");
            txtStatus.AppendText("Size: " + w + "x" + h + "\n");
            txtStatus.AppendText("Dir: " + dir + "\n");

            Random rand = new Random();
            int[,] mask = new int[w, h];
            txtStatus.AppendText("Mask: " + w + "x" + h + "\n");

            if (rdTypeBlock.Checked)
            {
                // Blocks

                int block_width = int.Parse(txtBlockWidth.Text);
                int block_height = int.Parse(txtBlockHeight.Text);
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

                txtStatus.AppendText("Blocks: " + block_count_x + " x " + block_count_y + "\n");

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
                            txtStatus.AppendText(px + " x " + py + " - " + ex.Message + "\n");
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
                txtStatus.AppendText("Get blocks: " + mx + " x " + my + "\n");
            }

            if (rdTypeLinesHorizontal.Checked)
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

            if (rdTypeLinesVertical.Checked)
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

            if (rdTypePixel.Checked)
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
            progressSingle.Maximum = w * h;
            progressSingle.Value = 0;
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
                            progressSingle.Value = progressSingle.Value + 1;
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
            dir = dir + "\\processed";
            //richTextBox1.AppendText("DirFIN: " + dir + "\n");


            relative_final_name = relative_final_name.PadLeft(count.ToString().Length, '0');

            txtStatus.AppendText("Save to: " + dir + "\\" + relative_final_name + ".png" + "\n");
            ///final.bmp
            //System.IO.Cre
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            fin.Save(dir + "\\" + relative_final_name + ".png", ImageFormat.Png);
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            if (dlgSelectFiles.ShowDialog() == DialogResult.OK)
            {
                processImages(dlgSelectFiles.FileNames, "");
            }
        }

        private void btnSequence_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog() == DialogResult.OK)
            {
                int frames_before = int.Parse(txtFramesBefore.Text);
                int frames_after = int.Parse(txtFramesAfter.Text);
                txtStatus.AppendText("frames be: " + frames_before + "; af: " + frames_after + "\n");

                //textBox1.Text = folderBrowserDialog1.SelectedPath;
                txtStatus.AppendText(dlgSelectFolder.SelectedPath + "\n");
                DirectoryInfo dirinfo = new DirectoryInfo(dlgSelectFolder.SelectedPath);
                FileInfo[] files = dirinfo.GetFiles();
                //FileInfo[] files = dirinfo.EnumerateFiles().OrderByDescending(x => x.Name);

                var filtered = files.Select(f => f)
                    .Where(f => (f.Attributes & FileAttributes.Hidden) == 0)
                    .OrderBy(f => f.Name);
                    //.OrderByDescending(f => f.Name);

                int frame_count = filtered.Count();
                txtStatus.AppendText("total frames: " + frame_count + "\n");

                progressSequence.Maximum = frame_count;
                progressSequence.Value = 0;

                //foreach (var f in files)
                int i = 0;
                foreach (var f in filtered)
                {
                    i++;
                    txtStatus.AppendText(f.FullName + "\n");

                    if (i > frames_before & i <= frame_count - frames_after)
                    {
                        txtStatus.AppendText("process: " + i + "\n");
                        int subframe_position = 0;

                        String[] frames_to_process = new String[frames_before + frames_after + 1];
                        //var frames_to_process = new List<string>[] { new List<string>(), new List<string>() };
                        //myList.Last().Ap
                        for (int b = frames_before; b > 0; b--)
                        {
                            //frames_to_process.Last().Add(filtered.ElementAt(i - b - 1).FullName);
                            frames_to_process[subframe_position] = filtered.ElementAt(i - b - 1).FullName;
                            subframe_position++;

                            txtStatus.AppendText("fb: " + filtered.ElementAt(i - b - 1).Name + "\n");
                        }

                        //frames_to_process.Last().Add(filtered.ElementAt(i - 1).FullName);
                        frames_to_process[subframe_position] = filtered.ElementAt(i - 1).FullName;
                        subframe_position++;

                        txtStatus.AppendText("cur: " + filtered.ElementAt(i - 1).Name + "\n");

                        for (int a = 1; a <= frames_after; a++)
                        {
                            //frames_to_process.Last().Add(filtered.ElementAt(i + a - 1).FullName);
                            frames_to_process[subframe_position] = filtered.ElementAt(i + a - 1).FullName;
                            subframe_position++;
                            txtStatus.AppendText("fa: " + filtered.ElementAt(i + a - 1).Name + "\n");
                        }

                        //String[] final = frames_to_process.ToArray();

                        processImages(frames_to_process, "" + i);

                        txtStatus.AppendText("-- end " + "\n\n");
                    }


                    progressSequence.Value = progressSequence.Value + 1;
                    Application.DoEvents();
                    //Debug.WriteLine(f);
                }

            }
        }
    }
}
