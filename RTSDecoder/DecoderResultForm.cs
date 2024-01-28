using System.Windows.Forms;

namespace RTSDecoder
{
    public partial class DecoderResultForm : Form
    {
        public DecoderResultForm()
        {
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = WizardData.Main;

            DataGridViewTextBoxColumn gameTimeColumn = new DataGridViewTextBoxColumn();
            gameTimeColumn.DataPropertyName = "GameTime";
            gameTimeColumn.HeaderText = "Время (Игровое)";
            gameTimeColumn.DefaultCellStyle.Format = "HH:mm:ss tt";
            dataGridView.Columns.Add(gameTimeColumn);

            DataGridViewTextBoxColumn realTimeColumn = new DataGridViewTextBoxColumn();
            realTimeColumn.DataPropertyName = "RealTime";
            realTimeColumn.HeaderText = "Время (Реальное)";
            realTimeColumn.DefaultCellStyle.Format = "HH:mm:ss tt";
            dataGridView.Columns.Add(realTimeColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Нарушение";
            descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.Add(descriptionColumn);
        }
    }
}
