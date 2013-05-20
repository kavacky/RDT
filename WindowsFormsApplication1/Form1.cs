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

        /*
         * Galvenā apstrāde
         */
        private void processImages(String[] filenames, String relative_final_name)
        {
            int width = 0;
            int height = 0;
            int count = 0;
            string dir = "";

            // Ielasam attēlu izmērus un skaitu
            foreach (String fn in filenames)
            {
                Image t = Image.FromFile(fn);
                width = t.Width;
                height = t.Height;
                dir = System.IO.Path.GetDirectoryName(fn);
                count++;
                t.Dispose();
            }

            txtStatus.AppendText("\nProcessing...\n");
            txtStatus.AppendText("Count: " + count + "\n");
            txtStatus.AppendText("Size: " + width + "x" + height + "\n");
            txtStatus.AppendText("Dir: " + dir + "\n");

            // Sākam veidot masku
            Random rand = new Random();
            int[,] mask = new int[width, height];
            txtStatus.AppendText("Mask: " + width + "x" + height + "\n");

            /*
             * x * y pikseļu bloki
             */
            if (rdTypeBlock.Checked)
            {
                // Nosakam bloku skaitu
                int block_width = int.Parse(txtBlockWidth.Text);
                int block_height = int.Parse(txtBlockHeight.Text);
                int block_count_x = width / block_width;
                int block_count_y = height / block_height;

                if (block_count_x < 1)
                {
                    block_count_x = 1;
                }
                if (block_count_y < 1)
                {
                    block_count_y = 1;
                }

                txtStatus.AppendText("Blocks: " + block_count_x + " x " + block_count_y + "\n");

                // Izveidojam masku blokiem
                int[,] blockmask = new int[block_count_x, block_count_y];
                for (int y = 0; y < block_count_y; y++)
                {
                    for (int x = 0; x < block_count_x; x++)
                    {
                        int rnd = rand.Next(0, count);
                        blockmask[x, y] = rnd;
                    }
                }

                // Pārnesam bloku masku uz pilno attēla masku
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int blockmask_x = x / block_width;
                        int blockmask_y = y / block_height;

                        // Likvidējam dalīšanas noapaļošanas iespējamās kļūdas
                        if (blockmask_x >= block_count_x)
                        {
                            blockmask_x = block_count_x - 1;
                        }
                        if (blockmask_x < 0)
                        {
                            blockmask_x = 0;
                        }

                        if (blockmask_y >= block_count_y)
                        {
                            blockmask_y = block_count_y - 1;
                        }
                        if (blockmask_y < 0)
                        {
                            blockmask_y = 0;
                        }

                        // Ienesam attēla maskas pikselī atbilstošu bloka maskas pikseli
                        int rnd = 0;
                        try
                        {
                            rnd = blockmask[blockmask_x, blockmask_y];
                        }
                        catch (System.IndexOutOfRangeException ex)
                        {

                        }
                        finally
                        {
                            
                        }
                        mask[x, y] = rnd;
                    }
                }
            }

            /*
             * Līnijas horizontāli
             */
            if (rdTypeLinesHorizontal.Checked)
            {
                for (int y = 0; y < height; y++)
                {
                    int rnd = rand.Next(0, count);
                    for (int x = 0; x < width; x++)
                    {
                        mask[x, y] = rnd;
                    }
                }
            }

            /*
             * Līnijas vertikāli
             */
            if (rdTypeLinesVertical.Checked)
            {
                for (int x = 0; x < width; x++)
                {
                    int rnd = rand.Next(0, count);
                    for (int y = 0; y < height; y++)
                    {
                        mask[x, y] = rnd;
                    }
                }
            }

            /*
             * Atsevišķi pikseļi
             */
            if (rdTypePixel.Checked)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int rnd = rand.Next(0, count);
                        mask[x, y] = rnd;
                    }
                }
            }

            // Veidojam gala attēlu
            Bitmap fin = new Bitmap(width, height);

            int n = 0;
            progressSingle.Maximum = width * height;
            progressSingle.Value = 0;

            // Pēc kārtas lasam visus norādītos attēlus
            foreach (String fn in filenames)
            {
                Bitmap t = new Bitmap(fn);
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        // Ierakstam gala attēlā šī attēla pikseļus, ja maskā tā norādīts
                        /*
                         * Šī ir tā vieta, kur jāveic pirmā optimizācija, kad nepieciešams,
                         * jo izmantota ļoti neefektīva metode pikseļu kopēšanai
                         */
                        if (mask[x, y] == n)
                        {
                            fin.SetPixel(x, y, t.GetPixel(x, y));
                            progressSingle.Value = progressSingle.Value + 1;
                            Application.DoEvents();
                        }
                    }
                }
                t.Dispose();
                n++;
            }
            
            dir = dir + "\\processed";

            // Lai nosaukumi būtu 0001, 0002, 0003, nevis 1, 2, 3
            relative_final_name = relative_final_name.PadLeft(count.ToString().Length, '0');

            txtStatus.AppendText("Save to: " + dir + "\\" + relative_final_name + ".png" + "\n");

            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            fin.Save(dir + "\\" + relative_final_name + ".png", ImageFormat.Png);
            txtStatus.AppendText("... complete!\n");
        }

        /*
         * Viens attēls
         */
        private void btnSingle_Click(object sender, EventArgs e)
        {
            // Atveram logu, kur lietotājs iezīmē attēlus
            txtStatus.AppendText("Single begin...\n\n");
            if (dlgSelectFiles.ShowDialog() == DialogResult.OK)
            {
                // Apstrādājam visus izvēlētos attēlus
                processImages(dlgSelectFiles.FileNames, "");
                txtStatus.AppendText("\n... single finished!\n");
            }
            else
            {
                txtStatus.AppendText("Canceled.\n");
            }
        }

        /*
         * Attēlu secība
         */
        private void btnSequence_Click(object sender, EventArgs e)
        {
            // Liekam izvēlēties direktoriju ar attēliem
            txtStatus.AppendText("Sequence begin...\n\n");
            if (dlgSelectFolder.ShowDialog() == DialogResult.OK)
            {
                txtStatus.AppendText("Reading folder: " + dlgSelectFolder.SelectedPath + "\n");
                DirectoryInfo dirinfo = new DirectoryInfo(dlgSelectFolder.SelectedPath);
                FileInfo[] files = dirinfo.GetFiles();

                // Sakārtojam alfabētiski, kas skaitļiem nozīmēs pēc kārtas
                var filtered = files.Select(f => f)
                    .Where(f => (f.Attributes & FileAttributes.Hidden) == 0)
                    .OrderBy(f => f.Name);

                // Kopējais atrasto attēlu skaits
                int frame_count = filtered.Count();
                txtStatus.AppendText("Frames total: " + frame_count + "\n");

                // Cik gara secība uz priekšu un atpakaļ no pašreizējā kadra
                int frames_before = int.Parse(txtFramesBefore.Text);
                int frames_after = int.Parse(txtFramesAfter.Text);
                txtStatus.AppendText("Frames before: " + frames_before + "; after: " + frames_after + "\n");

                progressSequence.Maximum = frame_count;
                progressSequence.Value = 0;

                // Ejam cauri visiem attēliem un apstrādājam
                int frame_current = 0;
                foreach (var f in filtered)
                {
                    frame_current++;
                    txtStatus.AppendText("\nFrame: " + f.FullName + "\n");

                    // Ja pašreizējam attēlam būs pilns iepriekšējo/nākamo attēlu komplekts...
                    if (frame_current > frames_before & frame_current <= frame_count - frames_after)
                    {
                        txtStatus.AppendText("Frame being processed: " + frame_current + "\n");
                        int subframe_position = 0;

                        // Vācam visus kadrus, kuri jāapstrādā pašreizējam kadram
                        String[] frames_to_process = new String[frames_before + frames_after + 1];
                        
                        // Kadri pirms pašreizējā
                        for (int b = frames_before; b > 0; b--)
                        {
                            frames_to_process[subframe_position] = filtered.ElementAt(frame_current - b - 1).FullName;
                            subframe_position++;
                            txtStatus.AppendText("Before: " + filtered.ElementAt(frame_current - b - 1).Name + "\n");
                        }

                        // Pašreizējais kadrs
                        frames_to_process[subframe_position] = filtered.ElementAt(frame_current - 1).FullName;
                        subframe_position++;
                        txtStatus.AppendText("Current: " + filtered.ElementAt(frame_current - 1).Name + "\n");

                        // Kadri pēc pašreizējā
                        for (int a = 1; a <= frames_after; a++)
                        {
                            frames_to_process[subframe_position] = filtered.ElementAt(frame_current + a - 1).FullName;
                            subframe_position++;
                            txtStatus.AppendText("After: " + filtered.ElementAt(frame_current + a - 1).Name + "\n");
                        }

                        // Apstrādājam visus savāktos kadrus
                        processImages(frames_to_process, "" + frame_current);

                        txtStatus.AppendText("Frame done!\n\n");
                    }
                    else
                    {
                        txtStatus.AppendText("Insufficient before/after frames for: " + frame_current + "\n");
                    }

                    progressSequence.Value = progressSequence.Value + 1;
                    Application.DoEvents();
                }
                txtStatus.AppendText("\n... sequence finished.\n");
            }
            else
            {
                txtStatus.AppendText("Canceled.\n");
            }
        }
    }
}
