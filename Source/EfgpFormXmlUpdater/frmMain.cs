using System;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace EfgpFormXmlUpdater {
    public partial class frmMain : Form {
        private EFGPDataContext efgp;
        private string formOID;
        private string connectionString;

        public frmMain(string[] args) {
            if (args.Length != 4) {
                MessageBox.Show("命令列參數必須為[資料庫主機位址] [資料庫名稱] [連線帳號] [連線密碼]");

                Environment.Exit(-1);
            }

            InitializeComponent();

            connectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", args[0], args[1], args[2], args[3]);
        }

        private void btnQueryFormXml_Click(object sender, EventArgs e) {
            try {
                queryFormXml(sender, e);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e) {
            try {
                efgp = new EFGPDataContext(connectionString);
                formOID = "";
                tipNotice.SetToolTip(btnQueryFormXml, "一般流程表單用");
                tipNotice.SetToolTip(btnQueryFormMaskXml, "Tiptop流程表單用");
                tipNotice.SetToolTip(btnUpdateFormXml, "回寫流程表單XML");
                tipNotice.SetToolTip(btnRestore, "取回前1次修改前的XML");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQueryFormMaskXml_Click(object sender, EventArgs e) {
            try {
                queryFormXml(sender, e);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void queryFormXml(object sender, EventArgs e) {
            if (txtProcessId.Text.Trim() == "") throw new Exception(tpgProcessId.Text + "必填");

            var formValues = from p in efgp.ProcessInstance
                             join l in efgp.LocalRelevantData on p.contextOID equals l.containerOID
                             join f in efgp.FormInstance on l.valueOID equals f.OID
                             where p.serialNumber == txtProcessId.Text
                             select new { f.OID, f.fieldValues, f.maskFieldValues };
            if (formValues.SingleOrDefault() == null) throw new Exception(txtProcessId.Text + "找不到流程表單XML");

            formOID = formValues.Single().OID;

            var queryType = ((Button)sender).Text.Replace("查詢", "");
            tpgFormXml.Text = queryType;

            switch (queryType) {
                case "流程表單XML":
                    if (formValues.Single().fieldValues == null) {
                        rtxFormXml.Clear();

                        throw new Exception(queryType + "無內容");
                    }

                    rtxFormXml.Xml = Regex.Replace(formValues.Single().fieldValues, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline).Trim();
                    break;

                case "流程表單遮罩XML":
                    if (formValues.Single().maskFieldValues == null) {
                        rtxFormXml.Clear();

                        throw new Exception(queryType + "無內容"); }

                    rtxFormXml.Xml = Regex.Replace(formValues.Single().maskFieldValues, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline).Trim();
                    break;

                default:
                    throw new Exception("查詢類型必須是[流程表單XML/流程表單遮罩XML]其中之一");
            }

            rtxFormXml.Select(0, 0);            
        }

        private void btnUpdateFormXml_Click(object sender, EventArgs e) {
            try {
                var formInstance = efgp.FormInstance.FirstOrDefault(f => f.OID == formOID);
                if (formInstance == null) throw new Exception(string.Format("找不到FormInstance OID={0}的紀錄", formOID));

                switch (tpgFormXml.Text) {
                    case "流程表單XML":
                        File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\FormXml.bak", formInstance.fieldValues);
                        formInstance.fieldValues = rtxFormXml.Text;
                        break;

                    case "流程表單遮罩XML":
                        File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\FormXml.bak", formInstance.maskFieldValues);
                        formInstance.maskFieldValues = rtxFormXml.Text;
                        break;

                    default:
                        throw new Exception("回寫類型必須是[流程表單XML/流程表單遮罩XML]其中之一");
                }

                efgp.SubmitChanges();

                MessageBox.Show("回寫成功");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e) {
            try {
                if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\FormXml.bak")) {
                    rtxFormXml.Xml = Regex.Replace(File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\FormXml.bak"), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline).Trim();                    
                }
                else {
                    throw new Exception("FormXml.bak");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtProcessId_DoubleClick(object sender, EventArgs e) {
            txtProcessId.Clear();
        }

        private void rtxFormXml_DoubleClick(object sender, EventArgs e) {
            rtxFormXml.SelectAll();
        }
    }
}