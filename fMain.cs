
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
                int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
                btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
            
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvBicycles.AutoGenerateColumns=false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.Name = "Рік";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Colour";
            column.Name = "Колір";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            column.Width = 80;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FrameLoadCapacity";
            column.Name = "Максимальне навантаження на раму";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Вага";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WasUsed";
            column.Name = "Використання";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WasDamaged";
            column.Name = "Пошкодження";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            bindSrcBicycles.Add(new Bicycle("Trek FX 3", 2022, "Black", 850, 120, 12, false, false));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            fBicycle fb = new fBicycle (bicycle);   
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Add(bicycle);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = (Bicycle)bindSrcBicycles.List[bindSrcBicycles.Position];

            fBicycle fb = new fBicycle( bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.List[bindSrcBicycles.Position] = bicycle;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcBicycles.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { bindSrcBicycles.Clear();}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }    
        }
    }
}
