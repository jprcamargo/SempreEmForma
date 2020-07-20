using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SempreEmForma
{
    public partial class formSEF : Form
    {
        public formSEF()
        {
            InitializeComponent();
        }

        void Limpar()
        {
            cbSala.Text = "";
            mtxtData.Text = "";
            mtxtHora.Text = "";
            cbSocio.Text = "";
            lblVEstado.Visible = false;
            lblVArea.Visible = false;
            lblVLoc.Visible = false;
            lblVNome.Visible = false;
        }



        SqlConnection Connect()
        {

            string conString = "Data Source=localhost;Initial Catalog=SempreEmForma;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }
        public bool attGrid()
        {
            try
            {
                SqlConnection con = Connect();
                con.Open();
                string select = "SELECT r.NroId as [Número da sala], r.NroSocio as [Id do Sócio], r.DataReserva as Data, r.Hora FROM Reserva r";
                SqlDataAdapter MySqlData = new SqlDataAdapter(select, con);
                DataTable dttb = new DataTable(), dttb2 = new DataTable();
                MySqlData.Fill(dttb);
                dgvReserva.DataSource = dttb;
                con.Close();
                con.Dispose();
                return true;
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Banco não encontrado", "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisar.Enabled = false;
                btnConfirmar.Enabled = false;
                btnCancelar.Enabled = false;
                btnLimpar.Enabled = false;
                return false;
            }
        }
        private void formSEF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sempreEmFormaDataSet.Reserva'. Você pode movê-la ou removê-la conforme necessário.
            //this.reservaTableAdapter.Fill(this.sempreEmFormaDataSet.Reserva);
            if (attGrid())
            {
                SqlConnection con = Connect();
                con.Open();

                string selectSala = "select NroId from SalaSquash";
                con = Connect();
                con.Open();
                SqlCommand cmdSala = new SqlCommand(selectSala, con);
                SqlDataReader DR = cmdSala.ExecuteReader();

                while (DR.Read())
                {
                    cbSala.Items.Add(DR[0]);
                }
                con.Close();
                con.Dispose();
                con = Connect();
                con.Open();

                string selectSocio = "select NroSocio from Socio";
                con = Connect();
                con.Open();
                SqlCommand cmdSocio = new SqlCommand(selectSocio, con);
                SqlDataReader DR2 = cmdSocio.ExecuteReader();

                while (DR2.Read())
                {
                    cbSocio.Items.Add(DR2[0]);
                }
                con.Close();
                con.Dispose();
            }
            
        }

        private void dgvSquash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.DataSource != null)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvReserva.DataSource;

                if (cbSala.Text == "" && cbSocio.Text == "")
                {
                    bs.RemoveFilter();
                    dgvReserva.DataSource = bs;
                }
                String filtro = "";
                if (cbSala.Text != "")
                {
                    if (filtro == "")
                    {
                        filtro += "[Número da sala] = " + cbSala.Text + "";
                    }
                    else
                    {
                        filtro += " AND  [Número da sala] = " + cbSala.Text + "";
                    }
                }
                if (cbSocio.Text != "")
                {
                    if (filtro == "")
                    {
                        filtro += "[Id do Sócio] = " + cbSocio.Text + "";
                    }
                    else
                    {
                        filtro += " AND  [Id do Sócio] = " + cbSocio.Text + "";
                    }
                }
                if (mtxtData.MaskFull)
                {
                    if (filtro == "")
                    {
                        filtro += "Data = '" + mtxtData.Text + "'";
                    }
                    else
                    {
                        filtro += " AND  Data = '" + mtxtData.Text + "'";
                    }
                }
                if (mtxtHora.MaskFull)
                {
                    if (filtro == "")
                    {
                        filtro += "Hora = '" + mtxtHora.Text + "'";
                    }
                    else
                    {
                        filtro += " AND  Hora = '" + mtxtHora.Text + "'";
                    }
                }
                bs.Filter = filtro;
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = Connect();
            con.Open();

            string selectSala = "SELECT ss.Estado, s.Localizacao, s.Area FROM SalaSquash ss JOIN Sala s ON ss.NroId = s.NroId WHERE ss.NroId = " + cbSala.Text + ";";
            con = Connect();
            con.Open();
            SqlCommand cmdSala = new SqlCommand(selectSala, con);
            SqlDataAdapter da = new SqlDataAdapter(cmdSala);
            DataTable dtLabels = new DataTable();
            da.Fill(dtLabels);
            lblVEstado.Visible = true;
            lblVEstado.Text = dtLabels.Rows[0][0].ToString();
            lblVLoc.Visible = true;
            lblVLoc.Text = dtLabels.Rows[0][1].ToString();
            lblVArea.Visible = true;
            lblVArea.Text = dtLabels.Rows[0][2].ToString();
            con.Close();
            con.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Connect();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reserva WHERE DataReserva = @Data AND Hora = @Hora AND NroId = @Sala", con);
                cmd.Parameters.AddWithValue("@Data", mtxtData.Text);
                cmd.Parameters.AddWithValue("@Hora", mtxtHora.Text);
                cmd.Parameters.AddWithValue("@Sala", cbSala.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                attGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Banco não encontrado");
            }
            
            
        }

        private void dgvReserva_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            cbSala.Text = dgvReserva.SelectedRows[0].Cells[0].Value + string.Empty;
            cbSocio.Text = dgvReserva.SelectedRows[0].Cells[1].Value + string.Empty;
            mtxtData.Text = dgvReserva.SelectedRows[0].Cells[2].Value + string.Empty;
            mtxtHora.Text = dgvReserva.SelectedRows[0].Cells[3].Value + string.Empty;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Connect();
                con.Open();
                if (mtxtData.Text != "" || mtxtHora.Text != "" || string.IsNullOrEmpty(cbSocio.Text) || string.IsNullOrEmpty(cbSala.Text))
                {
                    string selectSala = "SELECT DataReserva FROM Reserva WHERE DataReserva = '" + mtxtData.Text + "' AND Hora = '" + mtxtHora.Text + "' And NroId = " + cbSala.Text;
                    con = Connect();
                    con.Open();
                    SqlCommand cmdSala = new SqlCommand(selectSala, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSala);
                    DataTable dtLabels = new DataTable();
                    da.Fill(dtLabels);
                    if (dtLabels.Rows.Count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Reserva VALUES( @Data, @Hora, @Socio, @Sala)", con);
                        cmd.Parameters.AddWithValue("@Data", mtxtData.Text);
                        cmd.Parameters.AddWithValue("@Hora", mtxtHora.Text);
                        cmd.Parameters.AddWithValue("@Socio", cbSocio.Text);
                        cmd.Parameters.AddWithValue("@Sala", cbSala.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        attGrid();
                        //Status st = new Status();
                        //st.statusChange("Inserido");
                        //st.Show();
                        //                    attGrid();
                    }
                    else
                    {
                        MessageBox.Show("Já existe");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Banco não encontrado");
            }
            }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            attGrid();
        }

        private void cbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = Connect();
            con.Open();
            string selectSocio = "SELECT Nome FROM Socio WHERE NroSocio = " + cbSocio.Text + ";";
            con = Connect();
            con.Open();
            SqlCommand cmdSocio = new SqlCommand(selectSocio, con);
            SqlDataAdapter da = new SqlDataAdapter(cmdSocio);
            DataTable dtLabels = new DataTable();
            da.Fill(dtLabels);
            lblNome.Visible = true;
            lblVNome.Visible = true;
            lblVNome.Text = dtLabels.Rows[0][0].ToString();
            con.Close();
            con.Dispose();
        }

        private void mtxtHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
    