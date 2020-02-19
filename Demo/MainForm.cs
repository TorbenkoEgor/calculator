using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ninject;

namespace View
{
    public partial class MainForm : Form, IView
    {
        private IKernel kernel;
        private IPresenter presenter;

        public MainForm(IKernel kernel)
        {
            this.kernel = kernel;
            this.presenter = kernel.Get<IPresenter>();

            InitializeComponent();
        }

        public void ShowStatus(double percent, String status)
        {
            progressBar.Value = (int)(1e2 * percent);
            progressBox.Text = status;
        }

        public void ShowHistory(List<String> list, int pointer)
        {
            historyBox.BeginUpdate();

            historyBox.DataSource = list;

            historyBox.EndUpdate();

            if(pointer > 0)
                historyBox.SetSelected((int)pointer, true);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                presenter.FileOperation("save", saveFileDialog1.FileName);
            }
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("assign", inputBox.Text);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                presenter.FileOperation("load", openFileDialog1.FileName);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {
            
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("plus", inputBox.Text);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("minus", inputBox.Text);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("multiply", inputBox.Text);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("divide", inputBox.Text);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("square", inputBox.Text);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("power", inputBox.Text);
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("sqrt", inputBox.Text);
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("root", inputBox.Text);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("log", inputBox.Text);
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("factorial", inputBox.Text);
        }

        private void MeanButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("mean", inputBox.Text);
        }

        private void StdDevButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("stddev", inputBox.Text);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("reset", inputBox.Text);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("undo", inputBox.Text);
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("repeat", inputBox.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            presenter.PerformAction("clone", inputBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
