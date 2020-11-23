using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouSource_SortStrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (check()) {
                sortedList sortString = new sortedList();

                string selectedItem = cmbBox_Type.Items[cmbBox_Type.SelectedIndex].ToString();

                sortString.setInput(txtBox_input.Text);

                if (selectedItem == "Quick Sort")
                {
                    sortString.SetSortStrategy(new QuickSort());
                    lbl_Output.Text = "Sorted List: " + sortString.Sort();
                }
                else if (selectedItem == "Bubble Sort")
                {
                    sortString.SetSortStrategy(new BubbleSort());
                    lbl_Output.Text = "Sorted List: " + sortString.Sort();
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            

        }

        private bool check() {
            string error = "";
            if (string.IsNullOrWhiteSpace(txtBox_input.Text)) {
                error = "TextBox is empty or only contains whitespace\n";
            }
            if (cmbBox_Type.SelectedItem == null || cmbBox_Type.Items[cmbBox_Type.SelectedIndex].ToString() == "")
            {
                error += "Invalid ComboBox\n";
            }

            if (error != "") {
                MessageBox.Show(error);
                return false;
            }

            return true;

        }
    }
}
