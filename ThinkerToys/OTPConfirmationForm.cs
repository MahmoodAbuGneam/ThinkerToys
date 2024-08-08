using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ThinkerToys
{
    public partial class OTPConfirmationForm : Form
    {

        private string username;
        private string email;

        public OTPConfirmationForm(string username, string email)
        {
            InitializeComponent();
            this.username = username;
            this.email = email;
        }

        private void btnSubmitOTP_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text;
            if (VerifyOTP(username, enteredOTP))
            {
                MessageBox.Show("OTP confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool VerifyOTP(string username, string enteredOTP)
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Signup data file not found.");
                return false;
            }

            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];

                int lastRow = worksheet.UsedRange.Rows.Count;

                for (int i = 2; i <= lastRow; i++)
                {
                    if (worksheet.Cells[i, 2].Value?.ToString() == username)
                    {
                        string storedOTP = worksheet.Cells[i, 8].Value?.ToString();
                        string expiryTimeString = worksheet.Cells[i, 9].Value?.ToString();

                        if (string.IsNullOrEmpty(storedOTP) || string.IsNullOrEmpty(expiryTimeString))
                        {
                            MessageBox.Show($"Invalid data for user {username}.");
                            return false;
                        }

                        DateTime expiryTime = DateTime.Parse(expiryTimeString);

                        if (storedOTP == enteredOTP && DateTime.Now <= expiryTime)
                        {
                            worksheet.Cells[i, 7] = true; // Set IsConfirmed to true
                            workbook.Save();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("OTP verification failed. Please check the OTP and try again.");
                        }
                        break;
                    }
                }
                MessageBox.Show($"User {username} not found.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying OTP: " + ex.Message);
                return false;
            }
            finally
            {
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(true);
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private bool ResendOTP(string username, string email)
        {
            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];

                int rowCount = worksheet.UsedRange.Rows.Count;

                for (int i = 2; i <= rowCount; i++)
                {
                    if (worksheet.Cells[i, 2].Value.ToString() == username)
                    {
                        string newOTP = GenerateOTP();
                        worksheet.Cells[i, 8] = newOTP;
                        worksheet.Cells[i, 9] = DateTime.Now.AddMinutes(10);
                        workbook.Save();

                        EmailSender.SendOTPEmail(email, newOTP);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resending OTP: " + ex.Message);
                return false;
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }


        public string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void btnResendOTP_Click_1(object sender, EventArgs e)
        {
            if (ResendOTP(username, email))
            {
                MessageBox.Show("A new OTP has been sent to your email.", "OTP Resent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to resend OTP. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmitOTP_Click_1(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text;
            if (VerifyOTP(username, enteredOTP))
            {
                MessageBox.Show("OTP confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
