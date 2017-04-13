﻿using AzDeploy.Client;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InstallManager im = new InstallManager("adamosoftware", "install", "BlobakSetup.exe", "Blobak");            
            if (await im.IsNewVersionAvailableAsync())
            {
                MessageBox.Show(string.Join(", ", im.NewComponents.Select(fv => $"{fv.Filename} = {fv.Version}")));
            }
            else
            {
                MessageBox.Show("No new version available");
            }
        }
    }
}
