using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHFBT_XP
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public string Message
        {
            set
            {
                label_message.Text = value;
            }
            get
            {
                return label_message.Text;
            }
        }
    }
}