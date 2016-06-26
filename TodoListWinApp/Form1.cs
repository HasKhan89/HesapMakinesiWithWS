using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListWinApp.TodoListServiceRef;

namespace TodoListWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TodoListServiceRef.TodoListServiceSoapClient client =
            new TodoListServiceRef.TodoListServiceSoapClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGorevler();
        }

        private void LoadGorevler()
        {
            lstGorevler.DataSource = client.List();
            lstGorevler.DisplayMember = "Task";
            lstGorevler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IslemSonuc sonuc = client.Add(txtGorev.Text, chkTamamlandiMi.Checked);

            if (sonuc.Sonuc == true)
            {
                MessageBox.Show(sonuc.Mesaj);
                LoadGorevler();
            }
            else
            {
                MessageBox.Show(sonuc.Mesaj);
            }
        }

        private void lstGorevler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex > -1)
            {
                TodoListServiceRef.Gorev gorev = lstGorevler.SelectedItem as Gorev;

                txtGorev.Text = gorev.Task;
                chkTamamlandiMi.Checked = gorev.IsCompleted;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex > -1)
            {
                TodoListServiceRef.Gorev gorev = lstGorevler.SelectedItem as Gorev;

                gorev.Task = txtGorev.Text;
                gorev.IsCompleted = chkTamamlandiMi.Checked;

                IslemSonuc sonuc = client.Update(gorev);

                if (sonuc.Sonuc == true)
                {
                    MessageBox.Show(sonuc.Mesaj);
                    LoadGorevler();
                }
                else
                {
                    MessageBox.Show(sonuc.Mesaj);

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex > -1)
            {
                TodoListServiceRef.Gorev gorev = lstGorevler.SelectedItem as Gorev;

                IslemSonuc sonuc = client.Delete(gorev.Id);

                if (sonuc.Sonuc == true)
                {
                    MessageBox.Show(sonuc.Mesaj);
                    LoadGorevler();
                }
                else
                {
                    MessageBox.Show(sonuc.Mesaj);

                }
            }
        }
    }
}
