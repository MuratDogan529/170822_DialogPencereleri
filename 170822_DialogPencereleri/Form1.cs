using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170822_DialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            //Bütün dialog pencerelerini Show veya showdialog isminde metotları bulunur.
            //Bu metotlar dialog pencerelerini açmayı sağlar.
           DialogResult sonuc = fontDialog1.ShowDialog();
            if (sonuc== DialogResult.OK)
            {
                lblDenemeTahtasi.Font = fontDialog1.Font;
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\murat.dogan2\Desktop";
            openFileDialog1.Filter = "Jpeg Dosyası|*.jpeg|Jpg Dosyası|*.jpg|Png Dosyası|*.png";  
           DialogResult sonuc= openFileDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDenemeTahtasi.Text = openFileDialog1.FileName;//dosya ismi ve dizin yolunu verir

                label1.Text = openFileDialog1.SafeFileName;//Sadece dosya yolunu verir
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydedilecek Dosyayı Seçiniz";
            DialogResult sonuc= saveFileDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDenemeTahtasi.Text = saveFileDialog1.FileName;
            }
            
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=folderBrowserDialog1.ShowDialog();//klasör seçtirir
            if (sonuc==DialogResult.OK)
            {
                lblDenemeTahtasi.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDenemeTahtasi.ForeColor = colorDialog1.Color;
                label1.BackColor = colorDialog1.Color;
            }
        }
    }
}
