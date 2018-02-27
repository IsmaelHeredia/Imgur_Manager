// Imgur Manager 0.3
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;

namespace ImgurManager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        // Funciones

        public string subir_imagen(string image)
        {
            string retorno = "";
            WebClient cliente_web = new WebClient();
            cliente_web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            cliente_web.Headers.Add("Authorization", "Client-ID " + "29108b5ec0efcc7");
            System.Collections.Specialized.NameValueCollection parametros = new System.Collections.Specialized.NameValueCollection();
            try
            {
                parametros.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)));
                byte[] respuesta_encode = cliente_web.UploadValues("https://api.imgur.com/3/image",parametros);
                string contenido = Encoding.ASCII.GetString(respuesta_encode).ToString();
                Match regex = Regex.Match(contenido, "\"link\":\"(.*?)\"", RegexOptions.IgnoreCase);
                if (regex.Success)
                {
                    string link = regex.Groups[1].Value;
                    link = link.Replace(@"\/", "/");
                    retorno = link;
                }
            }
            catch
            {   
                retorno = "Error";
            }

            return retorno;
        }

        //

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(ImgurManager.Properties.Resources.formcreate);
            sound1.Play();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(ImgurManager.Properties.Resources.click);
            sound1.Play();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult archivo = openFileDialog1.ShowDialog();
            if (archivo == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog1.FileName;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(ImgurManager.Properties.Resources.click);
            sound1.Play();

            toolStripStatusLabel1.Text = "[+] Uploading ...";
            this.Refresh();

            if (File.Exists(txtFilename.Text))
            {
                txtLink.Text = subir_imagen(txtFilename.Text);
            }

            toolStripStatusLabel1.Text = "[+] Done";
            this.Refresh();

            SoundPlayer sound2 = new SoundPlayer(ImgurManager.Properties.Resources.scanfin);
            sound2.Play();
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(ImgurManager.Properties.Resources.click);
            sound1.Play();

            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtLink.Text);
            }
            catch
            {
                //
            }
        }

        private void txtFilename_DragDrop(object sender, DragEventArgs e)
        {
            List<string> archivos = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            txtFilename.Lines = archivos.ToArray();
        }

        private void txtFilename_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblPowered_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://imgur.com/");
        }

    }
}
