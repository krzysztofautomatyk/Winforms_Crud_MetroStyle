using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace WindowsFormsApp
{
    public partial class NewUser : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public NewUser()
        {
            InitializeComponent();
        }

 

        private void btnZmienZdjecie_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Filter= "Obrazy PNG|*.png|Obrazy JPEG|*.jpg", ValidateNames = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                        obj.Zdjecie = ofd.FileName;
                }
            }
            
        }
        /// <summary>
        /// Czyści wszystkie pola do wpisywania oraz zjdecie 
        /// </summary>
        void CzyscPola()
        {
            txtBoxImieINazwisko.Text = null;
            txtBoxEmail.Text = null;
            txtBoxDataUrodzenia.Text = null;
            txtBoxAdress.Text = null;
            txtBoxStudentID.Text = null;
            checkPlec.Checked = false;
            pictureBox.Image = null;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["StudenciDbString"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();


                    //Zawsze sprawdź czy zapytanie SQL działa ręcznie !!!
                    studentBindingSource.DataSource = db.Query<Student>("Select * from Studenci", commandType: CommandType.Text);
                    metroPanel1.Enabled = false;

                    Student obj = studentBindingSource.Current as Student;
                    {
                        if (obj != null)
                        {
                            if (!string.IsNullOrEmpty(obj.Zdjecie))
                                pictureBox.Image = Image.FromFile(obj.Zdjecie);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Wiadomość z problemem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajUzytkownika_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pictureBox.Image = null;
            metroPanel1.Enabled = true;
            studentBindingSource.Add(new Student());
            studentBindingSource.MoveLast();
            txtBoxImieINazwisko.Focus();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = false;
            studentBindingSource.ResetBindings(false);
            //CzyscPola();
            this.NewUser_Load(sender ,e);
        }

        private void btnEdytujUzytkownika_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            metroPanel1.Enabled = true;
            txtBoxImieINazwisko.Focus();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student obj = studentBindingSource.Current as Student;
                {
                    if (obj != null)
                    {
                        if (!string.IsNullOrEmpty(obj.Zdjecie))
                            pictureBox.Image = Image.FromFile(obj.Zdjecie);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Wiadomość z problemem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsunUzytkownika_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Czy jesteś pewny że chcesz usunąć ten wpis ?", "Czy jesteś pewień? ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    Student obj = studentBindingSource.Current as Student;
                    if (obj !=null)
                    {
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["StudenciDbString"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();

                            int result = db.Execute("Delete from Studenci where Id = @Id", new { Id = obj.Id }, commandType: CommandType.Text);
                            if (result !=0)
                            {
                                studentBindingSource.RemoveCurrent();
                                metroPanel1.Enabled = false;
                                pictureBox.Image = null;
                                objState = EntityState.Unchanged;
                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Wiadomość z problemem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                studentBindingSource.EndEdit();
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["StudenciDbString"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {

                            //p.Add("@TeamName", model.TeamName);
                            //p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                            //// Insert/update/exeute
                            //connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                            //model.Id = p.Get<int>("@id");


                            DynamicParameters p = new DynamicParameters();
                            p.Add("@Id",0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new
                            {
                                ImieINazwisko = obj.ImieINazwisko,
                                Email = obj.Email,
                                Adres = obj.Adres,
                                Plec = obj.Plec,
                                DataUrodzenia = obj.DataUrodzenia,
                                Zdjecie=obj.Zdjecie
                            });
                            db.Execute("DodajStudenta", p, commandType: CommandType.StoredProcedure);
                            obj.Id = p.Get<int>("@Id");
                        }
                        else if (objState==EntityState.Changed)
                        {
                            db.Execute("UpdateStudneta", new
                            {
                                Id = obj.Id,
                                ImieINazwisko = obj.ImieINazwisko,
                                Email = obj.Email,
                                Adres = obj.Adres,
                                Plec = obj.Plec,
                                DataUrodzenia = obj.DataUrodzenia,
                                Zdjecie = obj.Zdjecie
                            },
                            commandType: CommandType.StoredProcedure);
                        }


                        metroGrid.Refresh();
                        metroPanel1.Enabled = false;
                        objState = EntityState.Unchanged;


                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Wiadomość z problemem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkPlec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlec.CheckState == CheckState.Checked)
            {
                checkPlec.Text = "Kobieta";
            }
            else if (checkPlec.CheckState == CheckState.Unchecked)
            {
                checkPlec.Text = "Facet";
            }
            else
                checkPlec.Text = "???";
        }
    }
}
