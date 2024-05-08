using System;
using System.Data;
using System.Windows.Forms;
using Client.ServiceReference1;
using Client.Utils;


namespace Client
{
    public partial class Form1 : Form
    {
        ServiceClient service;
        Datasets a;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            service = new ServiceClient();

            a =  service.GetDatasets();
            

            dataGridViewIndustry.DataSource = a.IndustryDataSet.Tables[6];
            dataGridViewHoldings.DataSource = a.HoldingsDataSet.Tables[6];
            dataGridViewMaster.DataSource = a.MasterDataSet.Tables[6];

            dataGridViewHoldings.ReadOnly = false;
            dataGridViewMaster.ReadOnly = false;
            dataGridViewIndustry.ReadOnly = false;


            dataGridViewIndustry.Columns["IND_CODE"].HeaderText = "Код галузі";
            dataGridViewIndustry.Columns["IND_NAME"].HeaderText = "Назва галузі";
            dataGridViewIndustry.Columns["LONG_NAME"].HeaderText = "Повна назва галузі";


            dataGridViewMaster.Columns["SYMBOL"].HeaderText = "Символ";
            dataGridViewMaster.Columns["CO_NAME"].HeaderText = "Назва компанії";
            dataGridViewMaster.Columns["EXCHANGE"].HeaderText = "Біржа";
            dataGridViewMaster.Columns["CUR_PRICE"].HeaderText = "Поточна ціна";
            dataGridViewMaster.Columns["YRL_HIGH"].HeaderText = "Річний максимум";
            dataGridViewMaster.Columns["YRL_LOW"].HeaderText = "Річний мінімум";
            dataGridViewMaster.Columns["P_E_RATIO"].HeaderText = "P/E відношення";
            dataGridViewMaster.Columns["BETA"].HeaderText = "Бета";
            dataGridViewMaster.Columns["PROJ_GRTH"].HeaderText = "Прогнозний ріст";
            dataGridViewMaster.Columns["INDUSTRY"].HeaderText = "Галузь";
            dataGridViewMaster.Columns["PRICE_CHG"].HeaderText = "Зміна ціни";
            dataGridViewMaster.Columns["SAFETY"].HeaderText = "Безпека";
            dataGridViewMaster.Columns["RATING"].HeaderText = "Рейтинг";
            dataGridViewMaster.Columns["RANK"].HeaderText = "Ранг";
            dataGridViewMaster.Columns["OUTLOOK"].HeaderText = "Прогноз";
            dataGridViewMaster.Columns["RCMNDATION"].HeaderText = "Рекомендація";
            dataGridViewMaster.Columns["RISK"].HeaderText = "Ризик";


            dataGridViewHoldings.Columns["ACCT_NBR"].HeaderText = "Номер рахунку";
            dataGridViewHoldings.Columns["SYMBOL"].HeaderText = "Символ";
            dataGridViewHoldings.Columns["SHARES"].HeaderText = "Кількість акцій";
            dataGridViewHoldings.Columns["PUR_PRICE"].HeaderText = "Ціна покупки";
            dataGridViewHoldings.Columns["PUR_DATE"].HeaderText = "Дата покупки";



        }

        private void masterAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = a.MasterDataSet.Tables[6].NewRow();
            a.MasterDataSet.Tables[6].Rows.Add(newRow);
        }

        private void masterDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaster.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dataGridViewMaster.SelectedRows[0].DataBoundItem as DataRowView;
                a.MasterDataSet.Tables[6].Rows.Remove(selectedRow.Row);
            }
        }

        private void industryAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = a.IndustryDataSet.Tables[6].NewRow();
            a.IndustryDataSet.Tables[6].Rows.Add(newRow);
        }

        private void industryDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewIndustry.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dataGridViewIndustry.SelectedRows[0].DataBoundItem as DataRowView;
                a.IndustryDataSet.Tables[6].Rows.Remove(selectedRow.Row);
            }
        }

        private void holdingsAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = a.HoldingsDataSet.Tables[6].NewRow();
            a.HoldingsDataSet.Tables[6].Rows.Add(newRow);
        }

        private void holdingsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoldings.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dataGridViewHoldings.SelectedRows[0].DataBoundItem as DataRowView;
                a.HoldingsDataSet.Tables[6].Rows.Remove(selectedRow.Row);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                

                service.Save(a);

                MessageBox.Show("Дані успішно збережені.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }


        private void DataGridViewIndustry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewIndustry.Rows.Count)
            {

                int objectId = Convert.ToInt32(dataGridViewIndustry.Rows[e.RowIndex].Cells["IND_CODE"].Value);


                DataRow[] rows = a.MasterDataSet.Tables[6].Select("INDUSTRY = " + objectId.ToString());


                if (rows.Length > 0)
                {
                    DataTable dt = rows.CopyToDataTable();
                    dataGridViewMaster.DataSource = dt;
                }
                else
                {

                    MessageBox.Show("Об'єкт з ідентифікатором " + objectId.ToString() + " не знайдено");
                }
            }
        }


        private void DataGridViewMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMaster.Rows.Count)
            {

                string objectId = dataGridViewMaster.Rows[e.RowIndex].Cells["SYMBOL"].Value.ToString();


                DataRow[] rows = a.HoldingsDataSet.Tables[6].Select("SYMBOL = '" + objectId + "'");


                if (rows.Length > 0)
                {
                    DataTable dt = rows.CopyToDataTable();
                    dataGridViewHoldings.DataSource = dt;
                }
                else
                {

                    MessageBox.Show("Об'єкт з ідентифікатором " + objectId.ToString() + " не знайдено");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) =>
            MessageBox.Show(
                "Ігор Вялов\n" +
                "Катерина Біленко\n" +
                "Кароліна Гордієнко\n" +
                "Дарина Ковтун\n" +
                "Євген Ковтун"
                );

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e) => HelpUtils.ShowHelp(this, "content/main/main.html");

    }
}
