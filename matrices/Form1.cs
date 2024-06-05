namespace matrices
{
    public partial class Form1 : Form
    {
        private double[,,] temperatures;
        private int index;

        public Form1()
        {
            InitializeComponent();
            temperatures = new double[2, 2, 2];
            index = 0;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewMatrix.ColumnCount = 3;
            dataGridViewMatrix.Columns[0].Name = "Layer";
            dataGridViewMatrix.Columns[1].Name = "Row";
            dataGridViewMatrix.Columns[2].Name = "Column";
            dataGridViewMatrix.Columns.Add("Value", "Value");
        }

        private void BtnSaveTemperature_Click(object sender, EventArgs e)
        {
            if (index < 8)
            {
                if (double.TryParse(txtTemperature.Text, out double temperatura))
                {
                    int i = index / 4;
                    int j = (index / 2) % 2;
                    int k = index % 2;
                    temperatures[i, j, k] = temperatura;
                    dataGridViewMatrix.Rows.Add(i, j, k, temperatura);
                    index++;

                    txtTemperature.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid temperature.");
                }
            }
            else
            {
                MessageBox.Show("All temperatures have already been entered.");
            }
        }

        private void btnAverageTemp_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (double temp in temperatures)
            {
                sum += temp;
            }
            double average = sum / 8;
            MessageBox.Show("The average temperature is: " + average.ToString("0.00"));
        }

        private void btnClearMatrix_Click(object sender, EventArgs e)
        {
            index = 0;
            Array.Clear(temperatures, 0, temperatures.Length);
            dataGridViewMatrix.Rows.Clear();
            txtTemperature.Clear();

            MessageBox.Show("The data has been cleared correctly.");
        }
    }
}
