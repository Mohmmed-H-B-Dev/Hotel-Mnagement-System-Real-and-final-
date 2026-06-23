using Business_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.Users
{
    public partial class frmUserr_Info : Form
    {
        int _UserID = -1;
        clsUser _UserInfo = null;
        public frmUserr_Info(int UserID)
        {
            InitializeComponent();
            _UserID=UserID;
        }

        private void frmUserr_Info_Load(object sender, EventArgs e)
        {
          //if(_UserID!=-1)
          //  {
          //      _UserInfo = clsUser.FindByUserID(_UserID);
          //  }else
          //  {
          //      return;
          //  }
         
            ctrlUserCard1.LoadUserInfo(_UserID);

            //lblUserName.Text = _UserInfo.UserName;
            //lblUserID.Text=_UserInfo.UserID.ToString();
            //lblIsActive.Text= _UserInfo.IsActive ? "Yas" : "No";



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
