using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Windows.Forms;
using System.Drawing;
using  System.Data;
using System.Text.RegularExpressions;

namespace PrjMoneyLoans
{
    public class UtilityLoan
    {

         DBLConMoney getdataDB;
         //DataTable result;
        // DataRow r;
        
         public UtilityLoan()
        {
            getdataDB = new DBLConMoney();
        }
 
        private static string strInfo = "جمعية المحافظة على القرآن الكريم - إدارة الحلقات";

        private static string[] DayofWeekArabic = { 
        "السبت",
        "الأحد",
        "الاثنين",
        "الثلاثاء",
        "الابعاء",
        "الخميس",
        "الجمعة"
         };
         
        public static string CleanStringExceptNumbersEglish(string Str)
        {
             Str = Regex.Replace(Str, "[أ]+", "ا");
            Str = Regex.Replace(Str, "[إ]+", "ا");
          //  Str = Regex.Replace(Str, "[آ]+", "ا");
            Str = Regex.Replace(Str, "[ة]+", "ه");
            Str = Regex.Replace(Str, "[ـ]+", "");
            Str = Regex.Replace(Str, @"\s\s+", " ");
            Str = Regex.Replace(Str, @"^ ", "");
            Str = Regex.Replace(Str, @" $", "");

            return Str;

        }
        public static string CleanString(string Str)
        {
             Str = Regex.Replace(Str, "[0-9a-zA-Z]+", "");
            Str = Regex.Replace(Str, "[أ]+", "ا");
            Str = Regex.Replace(Str, "[إ]+", "ا");
           // Str = Regex.Replace(Str, "[آ]+", "ا");
            Str = Regex.Replace(Str, "[ة]+", "ه");
            Str = Regex.Replace(Str, "[ـ]+", "");
            Str = Regex.Replace(Str, @"\s\s+", " ");
            Str = Regex.Replace(Str, @"^ ", "");
            Str = Regex.Replace(Str, @" $", "");
 
            return Str;
        
        }
         
        public static string  GetDayofWeek(int D)
        { 
             D = D + 1;

             if (D == 7) D = 0;
            return DayofWeekArabic[D];
        }

        public  static bool  IsDate(string Dateinput)
        {
             bool result =true;

             DateTime input = new DateTime();
             try
            {

                input = Convert.ToDateTime(Dateinput);
            }
            catch
            {
                
                result = false;

            }

            return result;
        }


        public static string FormatDate(string Dateinput)
        {
            DateTime? input = new DateTime();
            try
            {

                input = Convert.ToDateTime(Dateinput);
            }
            catch
            {
                input = DateTime.Now;
            }

            return String.Format("{0:yyyy/MM/dd}", input);
        }


        public static void ClearColor(Form myform)
        {
             foreach (Control ctrl in myform.Controls)
            {
                 if (((ctrl.GetType() == typeof(TextBox) && !((TextBox)ctrl).ReadOnly)
                    || (ctrl.GetType() == typeof(MaskedTextBox) && !((MaskedTextBox)ctrl).ReadOnly)
                    || ctrl.GetType() == typeof(DateTimePicker) 
                    || ctrl.GetType() == typeof(ComboBox) 
                   ) && ctrl.Enabled && string.IsNullOrEmpty((string)ctrl.Tag)
                 )
                {
                    if (ctrl.BackColor == Color.Red  )
                    {
                        ctrl.BackColor = Color.White;
                    }
                }
              }
        }
          
        public static  void ClearForm(Form myform)
        {
            foreach (Control ctrl in myform.Controls)
            {

                 if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ctrl.Text = string.Empty;
                }
                else if (ctrl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)ctrl).CustomFormat = " "; 
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl.GetType() == typeof(DataGridView))
                {
                  ((DataGridView) ctrl).DataSource =  (new DataTable()) ;
 
                }
                 
            }
        }


        public static void FillForm(Form myform, DataTable MySrch)
        {
            foreach (Control ctrl in myform.Controls)
            {
                if ((ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox)) && (string) ctrl.Tag != "user")
                {
                     if (MySrch.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime))
                    {
                         ctrl.Text = FormatDate(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString());
                     }
                    else
                    {
                        ctrl.Text = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                     }
                }


                else if (ctrl.GetType() == typeof(ComboBox) && (string)ctrl.Tag != "user")
                {
                    if (string.IsNullOrEmpty(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()) || MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()=="0")
                    {
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    }
                    else
                    {
                         ((ComboBox)ctrl).SelectedValue = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                    }
                }

                else if (ctrl.GetType() == typeof(CheckBox) && (string) ctrl.Tag != "user")
                {
                    if (string.IsNullOrEmpty(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()) || MySrch.Rows[0][ctrl.Name.Substring(3)].ToString() == "2")
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                    else if (MySrch.Rows[0][ctrl.Name.Substring(3)].ToString() == "1")
                    {
                        ((CheckBox)ctrl).Checked = true;
                        ((CheckBox)ctrl).CheckState = CheckState.Checked; 
                    }
                }


                else if (ctrl.GetType() == typeof(DateTimePicker) && ctrl.Enabled )
                {
                    if (MySrch.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime)  && IsDate(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()))
                    {
                        
                        ((DateTimePicker)ctrl).Value  =Convert.ToDateTime(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString());
                        ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                        ((DateTimePicker)ctrl).CustomFormat = "yyyy/MM/dd";
                    }
                    else
                    {


                        ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                        ((DateTimePicker)ctrl).CustomFormat = " "; 
 
                      
                    }
                }
            
                   



            }

        }

        public static void FillForm(Form myform, DataTable MySrch, int CancelDoc )
        {
            foreach (Control ctrl in myform.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                {

                    if (CancelDoc == 0)
                    {
                        ctrl.Text = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                        ctrl.Enabled = true;

                    }

                    else
                    {
                        ctrl.Text = string.Empty; 
                        ctrl.Enabled = false;


                    }
                }


                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    if (string.IsNullOrEmpty(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()))
                    {
                        ((ComboBox)ctrl).SelectedIndex = -1;

                    }
                    else
                    {
                        if (CancelDoc == 0)
                        {
                            ((ComboBox)ctrl).SelectedValue = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                            ctrl.Enabled = true;
                        }

                        else
                        {
                            ((ComboBox)ctrl).SelectedIndex = -1;
                            ctrl.Enabled = false;


                        }
                    }
                }


            }

        }


        public  static bool chkField(Form myform)
        {
            bool result = true;

            foreach (Control ctrl in myform.Controls)
            {



                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                    {
                        if (ctrl.Tag.ToString().Length==0)
                        {


                            if (string.IsNullOrEmpty(ctrl.Text) || string.IsNullOrWhiteSpace(ctrl.Text))
                            {
                                result = false;
                                ctrl.BackColor = Color.Red;
                                MessageBox.Show(ctrl.Name + " " + "لطفا  ادخل بيانات صحيحة", strInfo);
                                ctrl.BackColor = Color.White;
                                break;
                            }
                        }

                    }

                    else if (ctrl.GetType() == typeof(ComboBox))
                    {
                        if (((ComboBox)ctrl).SelectedIndex == -1)
                        {
                            result = false;
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(ctrl.Name + " " + "لطفا  ادخل بيانات صحيحة", strInfo);
                            ctrl.BackColor = Color.White;

                            break;
                        }
                    }
                 
            }
            return result;
        }


        public static void ClearForm_WithinCtrl(Control myform)
        {
            foreach (Control ctrl in myform.Controls)
            {

                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ctrl.Text = string.Empty;
                }
                else if (ctrl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)ctrl).CustomFormat = " ";
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)ctrl).DataSource = (new DataTable());

                }

            }
        }

        public static void FillForm_WithinCtrl(Control myform, DataTable MySrch)
        {
            foreach (Control ctrl in myform.Controls)
            {
                if ((ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox)) && (string)ctrl.Tag != "user" && /* Only for Library Book ==>*/ ((string)ctrl.Tag != (string)ctrl.Text || string.IsNullOrEmpty((string)ctrl.Tag)     ))
                {
                    if (MySrch.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime))
                    {
                        ctrl.Text = UtilityLoan.FormatDate(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString());
                    }
                    else
                    {
                        ctrl.Text = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                    }
                }


                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    if (string.IsNullOrEmpty(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()))
                    {
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    }
                    else
                    {
                        ((ComboBox)ctrl).SelectedValue = MySrch.Rows[0][ctrl.Name.Substring(3)].ToString();
                    }
                }

                else if (ctrl.GetType() == typeof(CheckBox) && (string)ctrl.Tag != "user")
                {
                    if (MySrch.Rows[0][ctrl.Name.Substring(3)].ToString() == "1")
                    {
                        ((CheckBox)ctrl).Checked = true;
                        ((CheckBox)ctrl).CheckState = CheckState.Checked;
                    }
                    else
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                }


                else if (ctrl.GetType() == typeof(DateTimePicker) && ctrl.Enabled)
                {
                    if (MySrch.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime) && IsDate(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString()))
                    {
                        ((DateTimePicker)ctrl).Value = Convert.ToDateTime(MySrch.Rows[0][ctrl.Name.Substring(3)].ToString());


                        ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                        ((DateTimePicker)ctrl).CustomFormat = "yyyy/MM/dd";
                    }
                    else
                    {
                        ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                        ((DateTimePicker)ctrl).CustomFormat = " ";

                        //((DateTimePicker)ctrl).CustomFormat = "yyyy/MM/dd";
                        //((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;

                        //((DateTimePicker)ctrl).Value = DateTime.MinValue;
                        //((DateTimePicker)ctrl).Text = "";
                    }
                }





            }

        }


        public static bool ChkDataType(DataTable dt, Form myform)
        {
            bool Res = true;
            Control SelectedCtrl = new Control();

            try

            {


                foreach (Control ctrl in myform.Controls)
                {
                    SelectedCtrl = ctrl;

                    if (ctrl.GetType() == typeof(TextBox) && ctrl.Enabled && !((TextBox)ctrl).ReadOnly && string.IsNullOrEmpty((string)ctrl.Tag)
                     || (ctrl.GetType() == typeof(MaskedTextBox) && ctrl.Enabled && !((MaskedTextBox)ctrl).ReadOnly && string.IsNullOrEmpty((string)ctrl.Tag)))
                    {

                        if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(int) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(float) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(double) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(decimal) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(long))

                        {
                            if (!UtilityLoan.IsNumber(ctrl.Text))
                            {


                                ctrl.BackColor = Color.Red;

                                MessageBox.Show(" نوع البيانات خاطئ ليس رقما " + ctrl.Name, strInfo + myform.Controls.GetChildIndex(ctrl).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

                                ctrl.BackColor = Color.White;
                                Res = false;
                                break;
                            }
                        }

                        else if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime) && ctrl.Enabled)
                        {
                            if (!UtilityLoan.IsDate(ctrl.Text))
                            {
                                ctrl.BackColor = Color.Red;
                                MessageBox.Show(" نوع البيانات خاطئ ليس تاريخاً   " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ctrl.BackColor = Color.White;
                                Res = false;
                                break;
                            }
                        }

                        else if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(string) && (string.IsNullOrEmpty(ctrl.Text) || string.IsNullOrWhiteSpace(ctrl.Text)))
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" لا يجوز أن يكون البيانات فارغة " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;

                        }

                        //
                    }

                    else if (ctrl.GetType() == typeof(ComboBox) && ctrl.Enabled)
                    {
                        if (((ComboBox)ctrl).SelectedIndex == -1 || ((ComboBox)ctrl).SelectedValue.ToString() == "0")
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" نوع البيانات خاطئ   " + ctrl.Name, strInfo + myform.Controls.GetChildIndex(ctrl).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;
                        }
                    }
                    else if (ctrl.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)ctrl).CheckState == CheckState.Indeterminate)
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" يجب تحديد اختيارك " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;
                        }
                    }

                }

                return Res;
            }
            catch (Exception ee)
            {
                MessageBox.Show(SelectedCtrl.Name + ee.Message);
                return Res;
            }
        }


        public static bool ChkDataType________old(DataTable dt, Form myform)
        {
            bool Res = true;
            Control SelectedCtrl = new Control();
            try
            {

                foreach (Control ctrl in myform.Controls)
                {
                    SelectedCtrl=ctrl;

                    if (ctrl.GetType() == typeof(TextBox) && ctrl.Enabled && !((TextBox)ctrl).ReadOnly && string.IsNullOrEmpty((string)ctrl.Tag)
                     || (ctrl.GetType() == typeof(MaskedTextBox) && ctrl.Enabled && !((MaskedTextBox)ctrl).ReadOnly && string.IsNullOrEmpty((string)ctrl.Tag)))
                    {

                        if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(int) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(float) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(double) ||
                           dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(long))
                        {
                            if (!UtilityLoan.IsNumber(ctrl.Text))
                            {


                                ctrl.BackColor = Color.Red;

                                MessageBox.Show(" نوع البيانات خاطئ ليس رقما " + ctrl.Name, strInfo + myform.Controls.GetChildIndex(ctrl).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

                                ctrl.BackColor = Color.White;
                                Res = false;
                                break;
                            }
                        }

                        else if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(DateTime) && ctrl.Enabled)
                        {
                            if (!UtilityLoan.IsDate(ctrl.Text))
                            {
                                ctrl.BackColor = Color.Red;
                                MessageBox.Show(" نوع البيانات خاطئ ليس تاريخاً   " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ctrl.BackColor = Color.White;
                                Res = false;
                                break;
                            }
                        }

                        else if (dt.Columns[ctrl.Name.Substring(3)].DataType == typeof(string) && (string.IsNullOrEmpty(ctrl.Text) || string.IsNullOrWhiteSpace(ctrl.Text)))
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" لا يجوز أن يكون البيانات فارغة " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;
                        }

                        //
                    }

                    else if (ctrl.GetType() == typeof(ComboBox) && ctrl.Enabled)
                    {
                        if (((ComboBox)ctrl).SelectedIndex == -1 || ((ComboBox)ctrl).SelectedValue.ToString() == "0")
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" نوع البيانات خاطئ   " + ctrl.Name, strInfo + myform.Controls.GetChildIndex(ctrl).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;
                        }
                    }
                    else if (ctrl.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)ctrl).CheckState == CheckState.Indeterminate)
                        {
                            ctrl.BackColor = Color.Red;
                            MessageBox.Show(" يجب تحديد اختيارك " + ctrl.Name, strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrl.BackColor = Color.White;
                            Res = false;
                            break;
                        }
                    }

                }

                return Res;
            }

            catch (Exception ee) {

                MessageBox.Show(SelectedCtrl.Name + ee.Message );
                return Res;
            
            }
        }
        public static bool  IsNumber (object Num)
        {
            bool result;
            try
            {
                if (Num == null)
                {
                    result = false;
                    return result;
                }

                string Number = Num.ToString().Trim();
 
                int i;
                  result = true;
                int dot = 0;
 
                if (Number.Length == 0)
                {
                    result = false;
                    return result;
                }

              


                for (i = 0; i < Number.Length; i++)
                {
                    if (Number[i] == '.' )
                    {
                        dot++;
                        
                    if ( dot > 1 )
                    {
                        result = false;
                        break;
                    }
                    }

                  
                    else if  (!Char.IsNumber(Number[i]) )
                     {
                     result = false;
                        break;
                     }
                }
            }
            catch
            {
                result = false;
            }

            return result;


        }

    }
}