using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDataBase
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO MyAlbumsDAO = new AlbumsDAO();

            // Connect list and grid view
            albumBindingSource.DataSource = MyAlbumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }
    }
}
