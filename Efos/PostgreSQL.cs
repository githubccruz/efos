using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using ControlesEfos;
using System.IO;
using System.Drawing;

namespace Efos
{
    public class PostgreSQL
    {
        #region Connection String
            private static string server = "localhost";
            private static string port = "5435";
            private static string user = "postgres";
            private static string password = "strongstoall";
            private static string dataBase = "test";//"efos";
        #endregion

        private static string generarConexion()
        {
            return string.Format("Server={0}; port={1}; Database={2}; User ID={3}; Password={4};",
                server, port, dataBase, user, password);
        }

        public static DataTable Execute(string command)
        {
            string connstring = generarConexion();

            DataTable dtReturn = new DataTable();
            
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, conn)) 
                    {
                        dtReturn.Reset();
                        da.Fill(dtReturn);
                    }
                    conn.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString()+"\n>>>>>>>. "+command);
                dtReturn = null;
            }
            return dtReturn;
        }

        public static void FillComboBox(efosCombo combo, string valueMember, string displayMember, string tableData, string filter = "")
        {
            String cmd = String.Format("SELECT {0}, {1} FROM {2}", valueMember, displayMember, tableData);
            if (string.IsNullOrEmpty(filter) == false)
            {
                cmd += String.Format(" where {0} order by {1}" , filter,displayMember);

            }
            combo.DataSource = Execute(cmd);            
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;            
        }

        public static void FillComboBox(DataGridViewComboBoxColumn combo, string valueMember, string displayMember, string tableData, string filter = "")
        {
            string cmd = String.Format("SELECT {0}, {1} FROM {2}", valueMember, displayMember, tableData);
            if (!String.IsNullOrEmpty(filter))
            {
                cmd += " where " + filter;
            }
            combo.DataSource = Execute(cmd);
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;             
        }

        public static DataTable FillList(efosList lista, string valueMember, string displayMember, string tableData, string filter = "")
        {
            string cmd = String.Format("SELECT {0}, {1} FROM {2}", valueMember, displayMember, tableData);
            if (!String.IsNullOrEmpty(filter))
            {
                cmd += " where " + filter;
            }           
            DataTable result = Execute(cmd);
            lista.DataSource = result;
            lista.DisplayMember = displayMember;
            lista.ValueMember = valueMember;

            return result;
        }

        public static string getXML(DataTable dt, string rowName)
        {
            if (String.IsNullOrEmpty(rowName))
                rowName = "row";

            string xml ="<root>";
            string row = "";

            foreach (DataRow dr in dt.Rows)
            {
                row = "<"+rowName+" ";
                for (int i = 0; i < dt.Columns.Count; i++)                
                    row += dt.Columns[i].ColumnName.Trim() + "=\"" + dr[dt.Columns[i].ColumnName] + "\" ";
                
                row += "/>";
                xml += row;
            }
            xml += "</root>";

            if (dt.Rows.Count < 1)
                xml = "";

            return xml;
        }

        public static void guardarImagen(string tablaBD, string campoCodigo, string campoImagen, string codigo, string productImageFilePath)
        {
            string command = String.Format("UPDATE {0} SET {1} = @imagen WHERE {2}={3}", tablaBD, campoImagen, campoCodigo, codigo);
            string constring = generarConexion();

            using (NpgsqlConnection pgConnection = new NpgsqlConnection(constring))
            {
                try
                {
                    using (FileStream pgFileStream = new FileStream(productImageFilePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream)))
                        {
                            byte[] pgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
                            
                            using (NpgsqlCommand pgCommand = new NpgsqlCommand(command, pgConnection))
                            {
                                pgCommand.Parameters.AddWithValue("@imagen", pgByteA);
                                try
                                {
                                    pgConnection.Open();
                                    pgCommand.ExecuteNonQuery();
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.ToString() + "\n SaveImage_1 >>>>>>>. " + command);
                                }
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString() + "\n SaveImage_2 >>>>>>>. " + command);
                }
            }
        }

        public static Image extraerImagen(string codigo)
        {
            string connstring = generarConexion();

            using (NpgsqlConnection pgConnection = new NpgsqlConnection(connstring))
            {
                try
                {
                    using (NpgsqlCommand pgCommand = new NpgsqlCommand("SELECT imagpers FROM persona_encabezado WHERE coditerc=@codigo;", pgConnection))
                    {
                        pgCommand.Parameters.AddWithValue("@codigo", codigo);
                        try
                        {
                            pgConnection.Open();
                            Byte[] productImageByte = (Byte[])(pgCommand.ExecuteScalar());
                            if (productImageByte != null)
                            {
                                using (Stream productImageStream = new System.IO.MemoryStream(productImageByte))
                                {
                                    return Image.FromStream(productImageStream);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Persona no tiene imagen");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No hay conexion >>>>>>"+codigo);
                }
            }            
            return null;
        }
    }
}