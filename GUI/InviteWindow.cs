using System;
using System.Windows.Forms;



namespace Chess.GUI
{
    public partial class InviteWindow : Form
    {
        public delegate void OnChoiceEventHandler(object sender, OnChoiceEventArgs e);
        public event OnChoiceEventHandler OnChoice;
        private bool choiceMade = false;
        private delegate void LoadingDelegate(int delay);
      
       
        public InviteWindow()
        {
         
            InitializeComponent();
           
        }

        private void OfflineGameButton_Click(object sender, EventArgs e)
        {
            if (OnChoice != null)
            {
                OnChoice(this, new OnChoiceEventArgs(OnChoiceEventArgs.ConnectionType.OFFLINE, null));
                choiceMade = true;
            }
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void InviteWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!choiceMade && OnChoice != null)
                OnChoice(this, new OnChoiceEventArgs(OnChoiceEventArgs.ConnectionType.EXIT, null));
            choiceMade = false;
        }

    
    }


    public class OnChoiceEventArgs: EventArgs
    {
        public enum ConnectionType { SERVER, CLIENT, OFFLINE, EXIT };
        private ConnectionType type;
        public ConnectionType Type { get { return type; } }
        private string ip = null;
        public OnChoiceEventArgs(ConnectionType connectionType, string InternetProtocol)
        {
            ip = InternetProtocol;
            type = connectionType;
        }
    }
}
