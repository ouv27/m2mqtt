using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create client instance 
            MqttClient client = new MqttClient("test.mosquitto.org");

            client.Connect("Test VS",null,null);

 //           string strValue = Convert.ToString(value);

            // publish a message on "/home/temperature" topic with QoS 2 
            client.Publish("/home/temperature", Encoding.UTF8.GetBytes("test"));

        }
    }
}
