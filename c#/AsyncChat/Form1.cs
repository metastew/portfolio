using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChatClient;
using System.Threading;

namespace Ass2AsyncChat
{
    public partial class frmMain : Form
    {
        Client client = new Client();
        private Thread keepAlive;
        public delegate void getMsg();
        bool done = false;

        private getMsg MsgFromRemoteHost;

        public frmMain()
        {
            InitializeComponent();

            // start thread to keep connection open
            MsgFromRemoteHost = new getMsg(client.incomingMsg);
            // if there are data from server waiting to be recieved, send it to txtConversation textbox
            client.pendingMsg += new Client.receivedMsg(sendToForm);
        }

        private void sendToForm(string msg)
        {
            // send messages to txtConversation textbox
            txtConversation.Text += msg + "\r\n";
            txtConversation.SelectionStart = txtConversation.Text.Length;
            txtConversation.ScrollToCaret();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            done = true;
            client.endConnect();
            this.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!client.isConnected())
            {
                client.startConnect();
                keepAlive = new Thread(new ThreadStart(getMsgFromRemoteHost));

                keepAlive.Start();
            }
        }

        private void getMsgFromRemoteHost()
        {
            while(client.isConnected() && !done)
            {
                try
                {
                    txtConversation.Invoke(MsgFromRemoteHost);
                }
                catch (InvalidOperationException)
                {
                    client.outgoingMsg("Client has exited the conversation");
                    Application.DoEvents();
                }
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            done = true;
            client.outgoingMsg("Client has left the conversation");
            sendToForm("NOTICE: You have disconnected from remote host");
            client.endConnect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg;
            if (txtClientMessage.Text != "")
            {
                msg = txtClientMessage.Text;
                txtClientMessage.Text = "";
                txtConversation.Text += ">> " + msg + "\r\n";
                client.outgoingMsg(msg);
                txtConversation.SelectionStart = txtConversation.Text.Length;
                txtConversation.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("You haven't entered anything yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtClientMessage.Focus();
        }
    }
}
