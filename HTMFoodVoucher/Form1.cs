﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using RawPrint;

namespace HTMFoodVoucher
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVendor.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print();
        }

        private void btn_PrintAndIncrement_Click(object sender, EventArgs e)
        {
            print();
            nudID.Value = nudID.Value == 0 ? 0 : nudID.Value - 1;
        }     

        private void print()
        {
            PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();

            String sep = "\n------------------------------\n";

            var bytes = logo();
            
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, obj.FontSelect.FontA());
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, obj.Alignment.Center());
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(sep));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("  _    _ _______ __  __ \n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(" | |  | |__   __|  \\/  |\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(" | |__| |  | |  | \\  / |\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(" |  __  |  | |  | |\\/| |\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(" | |  | |  | |  | |  | |\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(" |_|  |_|  |_|  |_|  |_|"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(sep));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("HackTheMidlands4.0\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("Meal Voucher"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(sep));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("\n" + cmbVendor.Text + "\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("\n" + nudID.Value + "\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(sep));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, obj.FontSelect.FontB());
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("Valid for one meal only.\n"));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("This voucher is only redeemable at the\nabove vendor. "));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("For more information,\nplease contact one of the organisers."));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, obj.FontSelect.FontA());
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes(sep));
            bytes = PrinterUtility.PrintExtensions.AddBytes(bytes, Encoding.ASCII.GetBytes("\n\n\n\n"));
    
            if (File.Exists(".\\tmpPrint.print"))
            {
                File.Delete(".\\tmpPrint.print");
            }
            File.WriteAllBytes(".\\tmpPrint.print", bytes);
          
            IPrinter printer = new Printer();
            printer.PrintRawFile("POS-58", ".\\tmpPrint.print");
            try
            {
                File.Delete(".\\tmpPrint.print");
            }
            catch
            {

            }

        }
        
        private byte[] cutPage()
        {
            Console.Out.WriteLine("CUT PAGE");
            List<byte> obj = new List<byte>();
            obj.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            obj.Add(Convert.ToByte('V'));
            obj.Add((byte)66);
            obj.Add((byte)3);
            return obj.ToArray();
        }

        private byte[] logo()
        {
            //  Console.Out.WriteLine("LOGO");
            //  ImageConverter ic = new ImageConverter();
            //  return (byte[])ic.ConvertTo(Properties.Resources.htm, typeof(byte[]));
            //     Image image = Properties.Resources.htm;
            //     using (var stream = new MemoryStream())
            //    {
            //      image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            //       return stream.ToArray();
            //   }
            return new byte[0];

        }



    }
}
